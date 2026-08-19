namespace MyApp{ 
    public class BankAccount
{
    // private field to store the balance of the bank account
    private double balance;

    // function to deposit an amount into the bank account
    public void deposite(double amount){
        balance=balance + amount;
        Console.WriteLine("Amount has been deposite " + amount);
    }

// function to withdraw an amount from the bank account
    public void withdrawal(double amount){
        balance=balance - amount;
        Console.WriteLine("Amount has been withdrawal " + amount);
    }

// function to get the current balance of the bank account
    public double getbalance(){
        return balance;
    }

}

}