namespace MyApp{ 
    public class BankAccount
{
    private double balance;
    public void deposite(double amount){
        balance=balance + amount;
        Console.WriteLine("Amount has been deposite " + amount);
    }

    public void withdrawal(double amount){
        balance=balance - amount;
        Console.WriteLine("Amount has been withdrawal " + amount);
    }

    public double getbalance(){
        return balance;
    }

}

}