using VisitorPattern.Model;
using VisitorPattern.Model.Aggrigates;
using VisitorPattern.Model.Visitor;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Asset> assets = new List<Asset>() { 
        new BankAccount(),
        new Car(),
        new RealState(),
        };

        var visitor =new MonthlyIncomeCalculator();
        assets.ForEach(a => a.AcceptVisitor(visitor));
        Console.WriteLine(visitor.GetIncome());

        var vistor2 = new NetworthCalculatory();
        assets.ForEach(p => p.AcceptVisitor(vistor2));
        Console.WriteLine(vistor2.GetAmount());

        Console.ReadLine();
    }
}