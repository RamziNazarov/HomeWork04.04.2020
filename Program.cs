using System;

namespace HomeWork04._04
{
    class Employee 
    {
        public string imSotr {get;set;}
        public string famSotr {get;set;}
        public string dolzhnost {get;set;}
        public int stazh {get;set;}
        public Employee(string imSotr, string famSotr, string dolzhnost, int staz)
        {
            this.imSotr = imSotr;
            this.famSotr = famSotr;
            this.dolzhnost = dolzhnost;
            this.stazh = staz;
        }
        private static string[] dolzhArr = {"Программист","Инженер","Врач","Секретарь","Бизнесмен","Учитель","Директор","Гейммейкер","Фармацевт","Тренер"};
        private static int[] okladDolzh = {1200,3000,2300,1500,2700,1234,4134,1340,1234,5435};
        private static int[] stazhArr = {0,100,200,300,400,500,600,700,800,900};
        public void GetInfo ()
        {
            System.Console.WriteLine($"Должность: {dolzhnost}\nИмя: {imSotr}\nФамилия: {famSotr}");
        }
        public int GetPlusStazh ()
        {
            int sum = 0;
            for(int i = 0; i < stazhArr.Length; i++)
            {
                if(dolzhArr[i] == dolzhnost)
                {
                    sum += okladDolzh[i];
                }
                if(stazh > stazhArr.Length-1 && i < 1)
                {
                    sum += stazhArr[stazhArr.Length-1];
                }
                else if(i == stazh)
                {
                    sum += stazhArr[i];
                }
            }
            return sum;
        }
        public Employee(){}
        public void ShowListOfDolzh ()
        {
            System.Console.Write("Список профессий: ");
            
            for(int i = 0; i < dolzhArr.Length; i ++)
            {
                if(i == dolzhArr.Length-1)
                {
                    System.Console.Write(dolzhArr[i] + " ");
                }
                else {
                    System.Console.Write(dolzhArr[i] + ", ");
                }
            }
            System.Console.WriteLine();
        }
        public void ShowoOklad()
        {
            for(int i = 0; i < dolzhArr.Length;i++)
            {
                if(dolzhArr[i] == dolzhnost)
                {
                    System.Console.WriteLine($"У {dolzhArr[i]} зарплата = {okladDolzh[i]}");
                }
            }
        }
        public void ShowNalog()
        {
            double nalog = 0;
            for(int i = 0; i < dolzhArr.Length; i++)
            {
                if(dolzhArr[i] == dolzhnost)
                {
                    nalog += okladDolzh[i];
                }
                if(stazh > stazhArr.Length-1 && i < 1)
                {
                    nalog += stazhArr[stazhArr.Length-1];
                }
                else if(i == stazh)
                {
                    nalog += stazhArr[i];
                }
            }
            System.Console.WriteLine($"Размер зарплаты учитывая 13%({Math.Round((nalog*0.13),2)} сомон) налога и 1%({Math.Round((nalog*0.01),2)} сомон) пенсионного фонда с общей суммы {nalog} сомон с учетом стажа в {stazh} лет = {Math.Round((nalog - (nalog*0.01) - (nalog * 0.13)),2)} сомон");
        }
    }
    class Program
    {
        // static Converter[] converters = new Converter[100];
        // static string[] texts = new string[100];
        static void Main(string[] args)
        {   
            Employee employee = new Employee();
            employee.ShowListOfDolzh();
            System.Console.Write("Введите ваше имя: ");
            employee.imSotr = Console.ReadLine();
            System.Console.Write("Введите вашу фамилию: ");
            employee.famSotr = Console.ReadLine();
            System.Console.Write("Введите вашу профессию: ");
            employee.dolzhnost = Console.ReadLine();
            System.Console.Write("Введите ваш стаж: ");
            employee.stazh = int.Parse(Console.ReadLine());
            employee.GetInfo();
            employee.ShowoOklad();
            Console.WriteLine($"Зарплата с учетом стажа работы = " + employee.GetPlusStazh());
            employee.ShowNalog();
            // int k = 1;
            // int l = 0;
            // while(k != 5)
            // {
            //     Console.Clear();
            //     if(k == 1)
            //     {
            //         System.Console.Write("Введите сколько долларов стоит 100 сомон: ");
            //         double usd = double.Parse(Console.ReadLine());
            //         System.Console.Write("Введите сколько рублей стоит 100 сомон: ");
            //         double rub = double.Parse(Console.ReadLine());
            //         System.Console.Write("Введите сколько евро стоит 100 сомон: ");
            //         double eur = double.Parse(Console.ReadLine());
            //         System.Console.Write("Введите название для списка курсов: ");
            //         texts[l] = Console.ReadLine();
            //         converters[l] = new Converter(usd,rub,eur){};
            //         l++;
            //         System.Console.Write("Название списков курсов:");
            //         for(int i = 0; i < l; i++){
            //             if(i != l-1)
            //             System.Console.Write($" {i+1}. {texts[i]} ||");
            //             else System.Console.Write($" {i+1}. {texts[i]}");
            //         }
            //         System.Console.WriteLine();
            //         System.Console.Write("1. Для создания новых курсов\n2. Для конвертации из som в другие валюты\n3. Для конвертации из других валют в som\n5. Для выхода\n");
            //         System.Console.Write("Ваш выбор: ");
            //         k = int.Parse(Console.ReadLine());
            //     }
            //     else if(k == 2)
            //     {
            //         System.Console.Write("Введите название списка курсов: ");
            //         string text = Console.ReadLine();
            //         for(int i = 0; i < texts.Length; i++)
            //         {
            //             if(texts[i] == text)
            //             {
            //                 Converter convert = converters[i];
            //                 convert.Show();
            //                 System.Console.Write("Введите сколько сомон хотите конвертировать: ");
            //                 double muchMoney = double.Parse(Console.ReadLine());
            //                 System.Console.WriteLine("usd или доллар - для вывода конвертации в долларах\nrub или рубль - для вывода конвертации в рублях\neur или евро - для вывода конвертации в евро\nall или все - для вывода конвертации во всех валютах");
            //                 System.Console.Write("Введите в какую валюту: ");
            //                 string vKurs = Console.ReadLine();
            //                 System.Console.WriteLine(vKurs == "доллар" || vKurs == "usd"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.usd)} usd":
            //                 vKurs == "rub" || vKurs == "рубль"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.rub)} rub":
            //                 vKurs == "eur" || vKurs == "евро"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.eur)} rub":
            //                 vKurs == "all" || vKurs == "все"?$"{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.usd)} usd\n{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.rub)} rub\n{muchMoney} som = {ConvertToAnotherCurrency(muchMoney,convert.eur)} eur":
            //                 $"Такой валюты не существует");
            //                 System.Console.Write("Название списков курсов:");
            //                 for(int j = 0; j < l; j++){
            //                     if(j != l-1)
            //                     System.Console.Write($" {j+1}. {texts[j]} ||");
            //                     else System.Console.Write($" {j+1}. {texts[j]}");
            //                 }
            //                 System.Console.WriteLine();
            //                 System.Console.Write("1. Для создания новых курсов\n2. Для конвертации из som в другие валюты\n3. Для конвертации из других валют в som\n5. Для выхода\n");
            //                 System.Console.Write("Ваш выбор: ");
            //                 k = int.Parse(Console.ReadLine());
            //                 break;
            //             }
            //         }
            //     }
            //     else if(k == 3)
            //     {
            //         System.Console.Write("Введите название списка курсов: ");
            //         string text = Console.ReadLine();
            //         for(int i = 0; i < texts.Length; i++)
            //         {
            //             if(texts[i] == text)
            //             {
            //                 Converter convert = converters[i];
            //                 convert.Show();
            //                 System.Console.Write("Введите количество денег которое хотите конвертировать: ");
            //                 double muchMoney = double.Parse(Console.ReadLine());
            //                 System.Console.WriteLine("usd или доллар - для вывода конвертации из доллара\nrub или рубль - для вывода конвертации из рубля\neur или евро - для вывода конвертации из евро\nall или все - для вывода конвертации из всех валютах");
            //                 System.Console.Write("Введите из какой валюты: ");
            //                 string vKurs = Console.ReadLine();
            //                 System.Console.WriteLine(vKurs == "доллар" || vKurs == "usd"?$"{muchMoney} usd = {ConvertToSomoni(muchMoney,convert.usd)} som":
            //                 vKurs == "rub" || vKurs == "рубль"?$"{muchMoney} rub = {ConvertToSomoni(muchMoney,convert.rub)} som":
            //                 vKurs == "eur" || vKurs == "евро"?$"{muchMoney} eur = {ConvertToSomoni(muchMoney,convert.eur)} som":
            //                 vKurs == "all" || vKurs == "все"?$"{muchMoney} usd = {ConvertToSomoni(muchMoney,convert.usd)} som\n{muchMoney} rub = {ConvertToSomoni(muchMoney,convert.rub)} som\n{muchMoney} eur = {ConvertToSomoni(muchMoney,convert.eur)} som":
            //                 $"Такой валюты не существует");
            //                 System.Console.Write("Название списков курсов:");
            //                 for(int j = 0; j < l; j++){
            //                     if(j != l-1)
            //                     System.Console.Write($" {j+1}. {texts[j]} ||");
            //                     else System.Console.Write($" {j+1}. {texts[j]}");
            //                 }
            //                 System.Console.WriteLine();
            //                 System.Console.Write("1. Для создания новых курсов\n2. Для конвертации из som в другие валюты\n3. Для конвертации из других валют в som\n5. Для выхода\n");
            //                 System.Console.Write("Ваш выбор: ");
            //                 k = int.Parse(Console.ReadLine());
            //                 break;
            //             }
            //         }
            //     }
                
            // }
            Console.ReadKey();
        }
        // static double ConvertToAnotherCurrency(double muchMoney,double currency)
        // {
        //     double result = currency *muchMoney / 100;
        //     return result;
        // }
        // static double ConvertToSomoni(double muchMoney, double currency)
        // {
        //     double result = 100 * muchMoney / currency;
        //     return result;
        // }
    }
    // class Converter 
    // {
    //     public double usd {get;set;}
    //     public double rub {get;set;}
    //     public double eur {get;set;}
    //     public Converter(double usd, double rub, double eur)
    //     {
    //         this.usd = usd;
    //         this.rub = rub;
    //         this.eur = eur;
    //         System.Console.WriteLine($"{usd} usd = 100 som\n{rub} rub = 100 som\n{eur} eur = 100 som");
    //     }
    //     public void Show()
    //     {
    //         System.Console.WriteLine($"{usd} usd = 100 som\n{rub} rub = 100 som\n{eur} eur = 100 som");
    //     }
    // }
}
