using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Accounts 
    {
        string AccountNo;
        String CustomerName;
        String AccountType;
        char TransactionType;
        int Amount;
        int Balance;
        public Accounts()      // Default Constructor
        {
            Console.WriteLine("---Welcome to XXX Bank---");
            Console.WriteLine("Enter Customer Name-> ");
            CustomerName = Console.ReadLine();
            Console.WriteLine("Enter Customer Account No-> ");
            AccountNo = Console.ReadLine();
            Console.WriteLine("Enter Account Type (Current/Saving A/c)-> ");
            AccountType = Console.ReadLine();
            Console.WriteLine("Transaction type for Diposit (D), Withdrawl (W)->");
            TransactionType = Convert.ToChar(Console.ReadLine().ToUpper());
            if (TransactionType == 'D')
            {
                Console.WriteLine("Enter the ammount to Diposit-> ");
                Amount = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter the ammount to Withdraw-> ");
               Amount = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("Enter the Balance of A/c-> ");
            Balance = Convert.ToInt32(Console.ReadLine());
        }
        //For Adding money to account
        public void Credit(int amount)
        {
            Balance = Balance + amount;
        }
        //For Removing money from account
        public void Debit(int amount)
        {
            Balance = Balance - amount;
        }

        public void Update()
        {
            if (TransactionType == 'D')
                Credit(Amount);

            else if (TransactionType == 'W')
                if (Balance < Amount)
                    throw (new Insufficient_Bal_Exception("Insufficient Account Balance"));
                else
                    Debit(Amount);
        }
        // for displaying the Customer details
        public void ShowData()
        {
            Console.WriteLine($"Custtomer Name -> {CustomerName}");
            Console.WriteLine($"Account Number -> {AccountNo}");
            Console.WriteLine($"Account Type -> {AccountType}");
            Console.WriteLine($"Transaction Type -> {TransactionType}");
            Console.WriteLine($"Amount -> {Amount}");
            Console.WriteLine($"Balance ->{Balance}");
        }
    }
    
    //User Define Exception
    public class Insufficient_Bal_Exception : ApplicationException
    {
        public Insufficient_Bal_Exception(string msg) : base(msg)
        {

        }
    }
}
