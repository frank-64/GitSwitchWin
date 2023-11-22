using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitSwitchWin
{
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(accountTypeInput.Text) ||
                string.IsNullOrEmpty(emailInput.Text) ||
                string.IsNullOrEmpty(usernameInput.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create the Account object
            Account account = new Account()
            {
                AccountName = accountTypeInput.Text,
                Email = emailInput.Text,
                Username = usernameInput.Text
            };

            List<Account> accounts = new List<Account>();
            try
            {
                string json = File.ReadAllText("./accountsConfig.json");
                accounts = JsonConvert.DeserializeObject<List<Account>>(json);
            }
            catch (Exception ex)
            {

            }
            accounts.Add(account);
            var accountJson = JsonConvert.SerializeObject(accounts);
            File.WriteAllText("./accountsConfig.json", accountJson);

            GitSwitch gitSwitch = new GitSwitch();
            gitSwitch.SetupAccounts();

            this.Close();

            GitSwitch gitSwitchWindow = new GitSwitch();
            gitSwitchWindow.Show();
        }
    }
}
