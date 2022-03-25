using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    public class CustomException:Exception
    {
        public CustomException(string message):base(message)
        {

        }


    }
    public class BankAccount //Publisher Class
    {
        public event ZeroBalanceDlgt zero_balance_trigger;
        public event UpdateBalance update_balance_trigger;
        public Guid customerId { get;}
        public string customerName { get; set; }

        public  decimal bankBalance { get; set; }

        public BankAccount(string customerName,decimal bankBalance)
        {
            this.customerName = customerName;
            this.bankBalance = bankBalance;
        }

        public void Deposit(decimal amount)
        {
            if(amount==0||amount<0)
            {
                //Trigger Call Here
                zero_balance_trigger(customerName);

            }
            else
            {
                this.bankBalance += amount;
                update_balance_trigger(amount,customerName,bankBalance);
            }
           

        }

        public void WithDraw(decimal amount)
        {

            if(amount>bankBalance)
            {
                throw new CustomException("Amount Exceeds Current Bank Balance");
            }
            else if(amount==0||amount<0)
            {
                //Trigger Here
                throw new CustomException("Please Enter Valid Amount");
            }
            else
            {

                bankBalance -= amount;
                //Trigger Here
                update_balance_trigger(amount, customerName, bankBalance);
            }


        }


    }
}
