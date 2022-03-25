using System;

namespace DelegateDemo
{
    public delegate void ZeroBalanceDlgt(string name);
    public delegate void UpdateBalance(decimal amount, string name, decimal balance);
    public class DelegateDemo//Subscriber Class
    {
        
        static void Main(string[] args)
        {
            BankAccount sarveshAccount = new BankAccount("Sarvesh Patil",1500);
            sarveshAccount.zero_balance_trigger += zeroBalanceMsg;//Registering Handler For Event
            sarveshAccount.update_balance_trigger += balanceUpdated;//Registering Handler For Event
            sarveshAccount.Deposit(1500);
            sarveshAccount.WithDraw(0);
            
        }

        static void zeroBalanceMsg(string name)
        {

            Console.WriteLine("Zero Balance In Account Of Account Owner "+name);
        }

        static void balanceUpdated(decimal amount,string name,decimal balance)
        {

            Console.WriteLine("Amount Of Rs "+amount+" Is Added In Account of "+name+" Updated Balance Is :"+balance);
        }
    }
}
