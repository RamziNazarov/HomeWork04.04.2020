using System;

namespace HomeWork04._04
{
    class Program
    {
        static Converter[] converters = new Converter[100];
        static string[] texts = new string[100];
        static void Main(string[] args)
        {   
            int k = 1;
            int l = 0;
            while(k != 5)
            {
                Console.Clear();
                if(k == 1)
                {
                    System.Console.Write("Введите сколько долларов стоит 100 сомон: ");
                    double usd = double.Parse(Console.ReadLine());
                    System.Console.Write("Введите сколько рублей стоит 100 сомон: ");
                    double rub = double.Parse(Console.ReadLine());
                    System.Console.Write("Введите сколько евро стоит 100 сомон: ");
                    double eur = double.Parse(Console.ReadLine());
                    System.Console.Write("Введите название для списка курсов: ");
                    texts[l] = Console.ReadLine();
                    converters[l] = new Converter(usd,rub,eur){};
                    l++;
                    System.Console.Write("Название списков курсов:");
                    for(int i = 0; i < l; i++){
                        if(i != l-1)
                        System.Console.Write($" {i+1}. {texts[i]} ||");
                        else System.Console.Write($" {i+1}. {texts[i]}");
                    }
                    System.Console.WriteLine();
                    System.Console.Write("1. Для создания новых курсов\n2. Для конвертации из som в другие валюты\n3. Для конвертации из других валют в som\n5. Для выхода\n");
                    System.Console.Write("Ваш выбор: ");
                    k = int.Parse(Console.ReadLine());
                }
                else if(k == 2)
                {
                    System.Console.Write("Введите название списка курсов: ");
                    string text = Console.ReadLine();
                    for(int i = 0; i < texts.Length; i++)
                    {
                        if(texts[i] == text)
                        {
                            Converter convert = converters[i];
                            convert.Show();
                            System.Console.Write("Введите сколько сомон хотите конвертировать: ");
                            double muchMoney = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("usd или доллар - для вывода конвертации в долларах\nrub или рубль - для вывода конвертации в рублях\neur или евро - для вывода конвертации в евро\nall или все - для вывода конвертации во всех валютах");
                            System.Console.Write("Введите в какую валюту: ");
                            string vKurs = Console.ReadLine();
                            System.Console.WriteLine(vKurs == "доллар" || vKurs == "usd"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.usd)} usd":
                            vKurs == "rub" || vKurs == "рубль"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.rub)} rub":
                            vKurs == "eur" || vKurs == "евро"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.eur)} rub":
                            vKurs == "all" || vKurs == "все"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.usd)} usd\n{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.rub)} rub\n{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.eur)} eur":
                            $"Такой валюты не существует");
                            System.Console.Write("Название списков курсов:");
                            for(int j = 0; j < l; j++){
                                if(j != l-1)
                                System.Console.Write($" {j+1}. {texts[j]} ||");
                                else System.Console.Write($" {j+1}. {texts[j]}");
                            }
                            System.Console.WriteLine();
                            System.Console.Write("1. Для создания новых курсов\n2. Для конвертации из som в другие валюты\n3. Для конвертации из других валют в som\n5. Для выхода\n");
                            System.Console.Write("Ваш выбор: ");
                            k = int.Parse(Console.ReadLine());
                            break;
                        }
                    }
                }
                else if(k == 3)
                {
                    System.Console.Write("Введите название списка курсов: ");
                    string text = Console.ReadLine();
                    for(int i = 0; i < texts.Length; i++)
                    {
                        if(texts[i] == text)
                        {
                            Converter convert = converters[i];
                            convert.Show();
                            System.Console.Write("Введите количество денег которое хотите конвертировать: ");
                            double muchMoney = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("usd или доллар - для вывода конвертации из доллара\nrub или рубль - для вывода конвертации из рубля\neur или евро - для вывода конвертации из евро\nall или все - для вывода конвертации из всех валютах");
                            System.Console.Write("Введите из какой валюты: ");
                            string vKurs = Console.ReadLine();
                            System.Console.WriteLine(vKurs == "доллар" || vKurs == "usd"?$"{muchMoney} usd = {ConvertToSomoni(muchMoney,convert.usd)} som":
                            vKurs == "rub" || vKurs == "рубль"?$"{muchMoney} rub = {ConvertToSomoni(muchMoney,convert.rub)} som":
                            vKurs == "eur" || vKurs == "евро"?$"{muchMoney} eur = {ConvertToSomoni(muchMoney,convert.eur)} som":
                            vKurs == "all" || vKurs == "все"?$"{muchMoney} usd = {ConvertToSomoni(muchMoney,convert.usd)} som\n{muchMoney} rub = {ConvertToSomoni(muchMoney,convert.rub)} som\n{muchMoney} eur = {ConvertToSomoni(muchMoney,convert.eur)} som":
                            $"Такой валюты не существует");
                            System.Console.Write("Название списков курсов:");
                            for(int j = 0; j < l; j++){
                                if(j != l-1)
                                System.Console.Write($" {j+1}. {texts[j]} ||");
                                else System.Console.Write($" {j+1}. {texts[j]}");
                            }
                            System.Console.WriteLine();
                            System.Console.Write("1. Для создания новых курсов\n2. Для конвертации из som в другие валюты\n3. Для конвертации из других валют в som\n5. Для выхода\n");
                            System.Console.Write("Ваш выбор: ");
                            k = int.Parse(Console.ReadLine());
                            break;
                        }
                    }
                }
                
            }
            Console.ReadKey();
        }
        static double ConvertToAnotherCurrency(double muchMoney,double currency)
        {
            double result = currency *muchMoney / 100;
            return result;
        }
        static double ConvertToSomoni(double muchMoney, double currency)
        {
            double result = 100 * muchMoney / currency;
            return result;
        }
    }
    class Converter 
    {
        public double usd {get;set;}
        public double rub {get;set;}
        public double eur {get;set;}
        public Converter(double usd, double rub, double eur)
        {
            this.usd = usd;
            this.rub = rub;
            this.eur = eur;
            System.Console.WriteLine($"{usd} usd = 100 som\n{rub} rub = 100 som\n{eur} eur = 100 som");
        }
        public void Show()
        {
            System.Console.WriteLine($"{usd} usd = 100 som\n{rub} rub = 100 som\n{eur} eur = 100 som");
        }
    }
}
