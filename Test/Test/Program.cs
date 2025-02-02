// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Encapsulation : bundling the data (properties) and the methods (functions) that operate on the data into a single unit (class)
// It helps hiding the internal state of the object and only expose the necessary functionality

using Test.OopPrinciples.Encapsulation;

BadBankAccount account = new BadBankAccount();
account.balance = 1000;
Console.WriteLine(account.balance);

BankAccount bankAccount = new BankAccount(1000);
Console.WriteLine(bankAccount.GetBalance());
bankAccount.Deposit(500);
Console.WriteLine(bankAccount.GetBalance());
bankAccount.Withdraw(200);
Console.WriteLine(bankAccount.GetBalance());


//Abstraction : Hiding the complex implementation details and only showing the necessary functionality
// It helps in reducing the complexity of the code and helps in managing the code easily

