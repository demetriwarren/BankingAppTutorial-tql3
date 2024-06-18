using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Tutorial_tql3;

internal class InsufficientFundsException : Exception {

    public decimal Balance { get; set; }
    public decimal Amount { get; set; }

    public InsufficientFundsException() : base() { }
    
    public InsufficientFundsException(string message) : base(message) { }

    public InsufficientFundsException(string message, Exception exception) : base(message, exception) { }


}
