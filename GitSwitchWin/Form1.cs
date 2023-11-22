using Newtonsoft.Json;
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Security.Principal;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace GitSwitchWin
{
    public partial class GitSwitch : Form
    {
        public string globalEmail;
        public string globalName;
        public GitSwitch()
        {
            InitializeComponent();
            GetGlobalCredentials();
            SetupAccounts();
        }

        private void GetGlobalCredentials()
        {
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Arguments = "/c git config --list";
            p.StartInfo.FileName = "CMD.exe";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.Kill();

            try
            {
                Match emailMatch = Regex.Match(output, @"user.email=(.*)");
                Match nameMatch = Regex.Match(output, @"user.name=(.*)");

                if (emailMatch.Success)
                {
                    globalEmail = emailMatch.Groups[1].Value;
                }

                if (nameMatch.Success)
                {
                    globalName = nameMatch.Groups[1].Value;
                }

                currentEmailLabel.Text = $"Current Email: {globalEmail}";
                currentUsernameLabel.Text = $"Current Username: {globalName}";
            }
            catch
            {
                MessageBox.Show("Error", "No existing git credentials.");
            }
        }

        private List<Account> GetAccounts()
        {
            try
            {
                string json = File.ReadAllText("./accountsConfig.json");
                return JsonConvert.DeserializeObject<List<Account>>(json);
            }
            catch { 
                return new List<Account>();
            }
        }

        public void SetupAccounts()
        {
            var accounts = GetAccounts();
            if (accounts.Any())
            {
                List<Button> buttons = new List<Button>() { account1Button, account2Button, account3Button };
                buttons.ForEach(b => b.Visible = false);
                foreach (var account in accounts)
                {
                    var button = buttons.First();
                    if (account.Email == globalEmail)
                    {
                        button.BackColor = Color.CornflowerBlue;
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }
                    button.Visible = true;
                    button.Text = account.AccountName;
                    buttons.Remove(button);
                }
            }
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccountForm = new AddAccountForm();
            addAccountForm.Show();

            this.Hide();
        }

        private async void removeAccountButton_Click(object sender, EventArgs e)
        {
            var accounts = GetAccounts();

            accounts.Remove(accounts.Where(m => m.Email == globalEmail).First());
            var accountJson = JsonConvert.SerializeObject(accounts);
            await File.WriteAllTextAsync("./accountsConfig.json", accountJson);
            SetupAccounts();
        }

        private void account1Button_Click(object sender, EventArgs e)
        {
            var accounts = GetAccounts();
            var name = account1Button.Text;
            account1Button.BackColor = Color.CornflowerBlue;
            account2Button.BackColor = Color.White;
            account3Button.BackColor = Color.White;
            var account = accounts.Where(m => m.AccountName == name).First();
            SetGlobalAccount(account);
        }

        private void account2Button_Click(object sender, EventArgs e)
        {
            var accounts = GetAccounts();
            var name = account2Button.Text;
            account1Button.BackColor = Color.White;
            account2Button.BackColor = Color.CornflowerBlue;
            account3Button.BackColor = Color.White;
            var account = accounts.Where(m => m.AccountName == name).First();
            SetGlobalAccount(account);
        }

        private void account3Button_Click(object sender, EventArgs e)
        {
            var accounts = GetAccounts();
            var name = account3Button.Text;
            account1Button.BackColor = Color.White;
            account2Button.BackColor = Color.White;
            account3Button.BackColor = Color.CornflowerBlue;
            var account = accounts.Where(m => m.AccountName == name).First();
            SetGlobalAccount(account);
        }

        private void SetGlobalAccount(Account account)
        {
            globalEmail = account.Email;
            globalName = account.Username;

            currentEmailLabel.Text = $"Current Email: {globalEmail}";
            currentUsernameLabel.Text = $"Current Username: {globalName}";

            Process p = new Process();
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = $"/k git config --global user.name \"{globalName}\" & git config --global user.email \"{globalEmail}\"";

            p.Start();
            bool processExited = p.WaitForExit(500);

            if (!processExited)
            {
                // If the process hasn't exited within the timeout, kill it
                p.Kill();
            }
        }
    }
}