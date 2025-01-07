namespace BankAccountApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerText = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            button1 = new Button();
            Withdraw = new Button();
            Deposit = new Button();
            CreateAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 117);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 524);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 38);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            label2.Click += label2_Click;
            // 
            // OwnerText
            // 
            OwnerText.Location = new Point(183, 114);
            OwnerText.Name = "OwnerText";
            OwnerText.Size = new Size(311, 43);
            OwnerText.TabIndex = 2;
            OwnerText.TextChanged += textBox1_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(213, 522);
            AmountNum.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 999999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(281, 43);
            AmountNum.TabIndex = 3;
            AmountNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(542, 47);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 51;
            BankAccountsGrid.Size = new Size(882, 433);
            BankAccountsGrid.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(417, 537);
            button1.Name = "button1";
            button1.Size = new Size(10, 10);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Withdraw
            // 
            Withdraw.Location = new Point(1089, 512);
            Withdraw.Name = "Withdraw";
            Withdraw.Size = new Size(215, 61);
            Withdraw.TabIndex = 6;
            Withdraw.Text = "Withdraw";
            Withdraw.UseVisualStyleBackColor = true;
            Withdraw.Click += Withdraw_Click;
            // 
            // Deposit
            // 
            Deposit.Location = new Point(744, 512);
            Deposit.Name = "Deposit";
            Deposit.Size = new Size(246, 61);
            Deposit.TabIndex = 7;
            Deposit.Text = "Deposit";
            Deposit.UseVisualStyleBackColor = true;
            Deposit.Click += Deposit_Click;
            // 
            // CreateAccount
            // 
            CreateAccount.Location = new Point(224, 181);
            CreateAccount.Name = "CreateAccount";
            CreateAccount.Size = new Size(223, 61);
            CreateAccount.TabIndex = 8;
            CreateAccount.Text = "Create Account";
            CreateAccount.UseVisualStyleBackColor = true;
            CreateAccount.Click += CreateAccount_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 718);
            Controls.Add(CreateAccount);
            Controls.Add(Deposit);
            Controls.Add(Withdraw);
            Controls.Add(button1);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerText);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerText;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button button1;
        private Button Withdraw;
        private Button Deposit;
        private Button CreateAccount;
    }
}
