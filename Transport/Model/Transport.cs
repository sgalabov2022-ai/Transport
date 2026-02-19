using System;

public class Transport
{
	public Transport()
	{
		private double km;
	    public double Km
	{
		get;set;
	}
	private string time;
	public string Time
	{
		get;
		set;
	}

	public Transport(double km, string time)
	{
		Km = km;
		Time = time;

	}

	public Transport() : this(0,"") { }

    public static double CalculateCheapestPrice(int Km, string Time)
    {
        // Цена за такси
        double taxiStart = 0.70;
        double taxiPrice;

        if (Time == "day")
        {
            taxiPrice = taxiStart + Km * 0.79;
        }
        else
        {
            taxiPrice = taxiStart + Km * 0.90;
        }

        // Цена за автобус (ако е възможно)
        double busPrice = double.MaxValue;
        if (Km >= 20)
        {
            busPrice = Km * 0.09;
        }

        // Цена за влак (ако е възможно)
        double trainPrice = double.MaxValue;
        if (Km >= 100)
        {
            trainPrice = Km * 0.06;
        }

        // Най-ниска цена
        double minPrice = Math.Min(taxiPrice, Math.Min(busPrice, trainPrice));

        return minPrice;
    }

}
}
