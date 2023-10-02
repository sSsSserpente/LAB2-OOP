class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usdRate;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eurRate;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / plnRate;
    }

    public double ConvertFromUSD(double usd)
    {
        return usd * usdRate;
    }

    public double ConvertFromEUR(double eur)
    {
        return eur * eurRate;
    }

    public double ConvertFromPLN(double pln)
    {
        return pln * plnRate;
    }
}

class Program
{
    static void Main()
    {
        Converter converter = new Converter(28.1, 33.2, 7.6);

        double amountInUAH = 1000;
        Console.WriteLine($"{amountInUAH} UAH is approximately {converter.ConvertToUSD(amountInUAH):0.00} USD");
        Console.WriteLine($"{amountInUAH} UAH is approximately {converter.ConvertToEUR(amountInUAH):0.00} EUR");
        Console.WriteLine($"{amountInUAH} UAH is approximately {converter.ConvertToPLN(amountInUAH):0.00} PLN");

        double amountInUSD = 50;
        Console.WriteLine($"{amountInUSD} USD is approximately {converter.ConvertFromUSD(amountInUSD):0.00} UAH");

        double amountInEUR = 40;
        Console.WriteLine($"{amountInEUR} EUR is approximately {converter.ConvertFromEUR(amountInEUR):0.00} UAH");

        double amountInPLN = 120;
        Console.WriteLine($"{amountInPLN} PLN is approximately {converter.ConvertFromPLN(amountInPLN):0.00} UAH");

        Console.ReadLine(); 
    }
}
