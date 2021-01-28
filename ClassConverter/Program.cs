using System;

namespace ClassConverter
{
    class Converter
    {
        private double usd;
        private double eur;
        private double rub;
        public double n;
        public string value;
        public string val;
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
        public void Convert()
        {
            if (value == "usd") Console.WriteLine($"Ваша сумма в сомони: {UsdToSom()}");
            else if (value == "eur") Console.WriteLine($"Ваша сумма в сомони: {EurToSom()}");
            else if (value == "rub") Console.WriteLine($"Ваша сумма в сомони: {RubToSom()}");
            else if (value == "som")
            {
                switch (val)
                {
                    case "usd": Console.WriteLine($"Ваша сумма в долларах: {SomToUsd()}");
                    break;
                    case "eur": Console.WriteLine($"Ваша сумма в долларах: {SomToEur()}");
                    break;
                    case "rub": Console.WriteLine($"Ваша сумма в долларах: {SomToRub()}");
                    break;
                    default: Console.WriteLine("Вы ввели неправильное обозначение для вашей валюты!");
                    break;
                }
            }
            else Console.WriteLine("Вы ввели неправильное обозначение для вашей валюты!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вас приветствует класс Converter");
            Console.ForegroundColor = ConsoleColor.White;
            Converter cw = new Converter(11.13, 13.74, 0.154);
            Console.Write("Введите вашу сумму: "); double.TryParse(Console.ReadLine(), out double sum);
            Console.WriteLine("Введите наименование вашей купюры:");
            Console.WriteLine("usd -> Доллар США");
            Console.WriteLine("eur -> Евро");
            Console.WriteLine("rub -> Рубль");
            Console.WriteLine("som -> Сомони"); string v = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            cw.currencyExchangeRate();
            Console.ForegroundColor = ConsoleColor.White;
            if (v == "som")
            {
                Console.Write("Выберете в какую валюту хотите конвертировать свой сомони:\n(для доллара usd, для евро eur, для рубля rub): ");
                string val = Console.ReadLine();
                cw.val = val;
            }
            cw.value = v;
            cw.n = sum;
            
            cw.Convert();
            Console.ForegroundColor = ConsoleColor.White;
            
        }
    }
}
