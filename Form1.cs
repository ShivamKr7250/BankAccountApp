namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount1 = new BankAccount();
            bankAccount1.Owner = "Shivam Kumar";
            bankAccount1.AccountNumber = Guid.NewGuid();

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Owner = "Satyam Kumar";
            bankAccount2.AccountNumber = Guid.NewGuid();

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Owner = "Shyam Kumar";
            bankAccount3.AccountNumber = Guid.NewGuid();

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount1);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountsGrid.DataSource = bankAccounts;
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
    }
}
