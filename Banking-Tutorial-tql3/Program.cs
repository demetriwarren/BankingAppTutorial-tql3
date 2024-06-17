namespace Banking_Tutorial_tql3;

internal class Program {

    static void Main(string[] args) {

        var a1 = new Savings("Savings1");
        var a2 = new Savings("Savings2");

        Console.WriteLine($"Balance is {a1.Balance:C}");
        a1.Deposit(500);
        Console.WriteLine($"Balance is {a1.Balance:C}");
        a1.Withdraw(230);
        Console.WriteLine($"Balance is {a1.Balance:C}");
        a1.Withdraw(300);
        Console.WriteLine($"Balance is {a1.Balance:C}");
        a1.Deposit(-200);
        Console.WriteLine($"Balance is {a1.Balance:C}");

        a1.Transfer(100, a2);

        a2.Transfer(50, a1);

        Console.WriteLine($"Balance is {a1.Balance:C}");
        a1.CalcAndPayInterest(1);
        Console.WriteLine($"Balance is {a1.Balance:C}");

    }
}
