using System;

namespace ClassConverter
{
    class Converter
    {
        private double usd;
        private double eur;
        private double rub;
        public double n;
        public Converter(){}
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public double SomToUsd()
        {
            return Math.Round((n / usd), 3);
        }
        public double UsdToSom()
        {
            return Math.Round((n * usd), 3);
        }
        public double SomToEur()
        {
            return Math.Round((n / eur), 3);
        }
        public double EurToSom()
        {
            return Math.Round((n * eur), 3);
        }
        public double SomToRub()
        {
            return Math.Round((n / rub), 3);
        }
        public double RubToSom()
        {
            return Math.Round((n * rub), 3);
        }
        public void currencyExchangeRate()
        {
            Console.WriteLine("Курс валют: ");
            Console.WriteLine($"1 usd => {usd} som");
            Console.WriteLine($"1 eur => {eur} som");
            Console.WriteLine($"1 rub => {rub} som");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
