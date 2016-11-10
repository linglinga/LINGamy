using System;

class BankAccount
{
    // create the balance field
    private decimal balance;

    //create a constructor

    public BankAccount()
    {
        balance = 0; //initialize balance in constructor. start with a zero balance.
    }
    //create the deposit function

    public void Deposit(decimal deci)
    {
        balance = balance + deci; // code here to calculate new balance after deposit
    }

    // create the withdrawal function
    public void Withdrawal(decimal deci) 
    {
        balance = balance - deci; // code here to calculate new balance after withdrawal
    }

    //create an accessing function to find what your current balance is
    public decimal GetBalance()  // returns the balance in decimal
    {
        return balance; //code here to deliver balance to end-user
    }
}

class Test
{
    static void Main()
    {
        BankAccount acct = new BankAccount();
        // client want sto deposit 200, withdrawal 40 and GetBalance.
        acct.Deposit(200m); // m is a decimal.
        
        acct.Withdrawal(40m);

        Console.WriteLine("The final balance is {0}", acct.GetBalance());

        Console.ReadLine();
    }
}