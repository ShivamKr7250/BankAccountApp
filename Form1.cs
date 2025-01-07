namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerText.Text))
            {
                MessageBox.Show("Owner name is required");
                return;
            }

            BankAccount bankAccount = new BankAccount(OwnerText.Text);
            bankAccounts.Add(bankAccount);
            Refresh();
            OwnerText.Text = string.Empty;

        }

        private void Refresh()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = bankAccounts;
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string msg = selectedBankAccount.Deposit(AmountNum.Value);
                Refresh();
                AmountNum.Value = 0;
                MessageBox.Show(msg);

            }
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string msg = selectedBankAccount.Withdraw(AmountNum.Value);
                Refresh();
                AmountNum.Value = 0;
                MessageBox.Show(msg);

            }
        }
    }
}
