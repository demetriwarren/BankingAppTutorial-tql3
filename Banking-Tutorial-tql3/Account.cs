using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Tutorial_tql3;

public class Account {

    public int AccountId { get; set; } = 0;
    public string Description { get; set; } = string.Empty;
    public decimal Balance { get; set; } = 0;

    public bool Deposit(decimal Amount) {
        if(Amount <= 0) {
            Console.WriteLine("Amount cannot be zero or negative!");
            return false;
        }
        Balance += Amount;
        return true;
    }

    public bool Withdraw(decimal Amount) {
        if(Amount <= 0) {
            Console.WriteLine("Amount cannot be zero or negative!");
            return false;
        }
        if(Amount > Balance) {
            Console.WriteLine("Insufficient Funds!");
            return false;
        }
        Balance -= Amount;
        return true;
    }

    public bool Transfer(decimal Amount, Account ax) {
        var success = this.Withdraw(Amount);
        if(success == true) {
            ax.Deposit(Amount);
        }
        return true;
    }
}
