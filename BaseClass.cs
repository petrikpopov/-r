using System;
namespace HM13._02._2023
{
    /*public class Moneys
    {
        public int Grivna;
        public int Dolar;
        public int Evro;

        public Moneys() { }
        public Moneys(int G, int D, int E)
        {
            Grivna = G;
            Dolar = D;
            Evro = E;
        }
    }
    public class Products : Moneys
    {
        public string Product;

        public Products() { }
        public Products(string P, int G, int D, int E) :base(G, D, E)
        {
            Product = P;
        }
        public void G()
        {
            int Chek = 0;
            int P;
            Console.Write("Введите стоимость товара:");
            P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите на сколько вы хотите еменьшить сумму товара:");
            Grivna = Convert.ToInt32(Console.ReadLine());
            Chek = P - Grivna;
            Console.Write("Ваша сумма = "+Chek);
        }
        public void D()
        {
            int P;
            Console.Write("Введите стоимость товара:");
            P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите на сколько вы хотите еменьшить сумму товара:");
            Dolar = Convert.ToInt32(Console.ReadLine());
            int Buff = 0;
            Buff = P - Dolar;
            Console.Write("Ваша сумма = " + Buff);
        }
        public void E()
        {
            int P;
            Console.Write("Введите стоимость товара:");
            P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите на сколько вы хотите еменьшить сумму товара:");
            Dolar = Convert.ToInt32(Console.ReadLine());
            int Buff = 0;
            Buff = P - Dolar;
            Console.Write("Ваша сумма = " + Buff);
        }
    }*/

    /*public class Uctroistvo
    {
        public string Name;

        public Uctroistvo (){}
        public Uctroistvo(string N)
        {
            Name = N;
           
        }
        public void Nam()
        {
            Console.WriteLine("Введите название устройства");
            Name = Convert.ToString(Console.ReadLine());
        }
    }
    public class Chainik: Uctroistvo
    {
        public string Color { set; get; }
        public string Made_in { set; get; }
        public Chainik() { }

        public Chainik(string C, string M, string N) :base(N)
        {
            Color = C;
            Made_in = M;
        }

        public void Show()
        {
            base.Nam();
        }
        public void Desc()
        {
            Console.WriteLine("Введите цвет устройства");
            Color = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите место изготовления");
            Made_in = Convert.ToString(Console.ReadLine());

        }
        public void Sound()
        {
            Console.WriteLine("Чайник издает звук ------> ППППШШШШШШ");
        }

    }
    public class Microvolnovka : Uctroistvo
    {
        public string Made_in;

        public Microvolnovka() { }
        public Microvolnovka(string Mi, string N):base(N)
        {
            Made_in = Mi;
        }
        public void Show()
        {
            base.Nam();

        }
        public void Desc()
        {
            
            Console.WriteLine("Введите место изготовления");
            Made_in = Convert.ToString(Console.ReadLine());

        }
        public void Sound()
        {
            Console.WriteLine("Микровалновка издает звук ------> ББББРРРРР");
        }

    }
    public class Car : Uctroistvo
    {
        public string Made_in;
        public string Max_Speed;
        public string Color;
        public Car() { }
        public Car(string Mi,string MX, string C, string N) : base(N)
        {
            Made_in = Mi;
            Max_Speed = MX;
            Color = C;
        }
        public void Show()
        {
            base.Nam();

        }
        public void Desc()
        {

            Console.WriteLine("Введите место изготовления");
            Made_in = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите максимальную скорость");
            Max_Speed = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите цвет машины");
            Color = Convert.ToString(Console.ReadLine());

        }
        public void Sound()
        {
            Console.WriteLine("Машина издает звук ------> НИУНЬ БРРР");
        }
    }
    public class Parohod : Uctroistvo
    {
        public string Made_in;
        public string Max_People;
        public string Colvo_Floor;
        public Parohod() { }
        public Parohod(string Mi, string MP, string CF, string N) : base(N)
        {
            Made_in = Mi;
            Max_People = MP;
            Colvo_Floor = CF;
        }
        public void Show()
        {
            base.Nam();

        }
        public void Desc()
        {

            Console.WriteLine("Введите место изготовления");
            Made_in = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите максимальное количесво людей");
            Max_People = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите количесвто этажей");
            Colvo_Floor = Convert.ToString(Console.ReadLine());

        }
        public void Sound()
        {
            Console.WriteLine("Параход издает звук ------> ББББРРРРРР ПППШШШШ");
        }
    }*/

    public class Musicalinstrument
    {
        public string Name;

        public Musicalinstrument() { }
        public Musicalinstrument(string N)
        {
            Name = N;

        }
        public void Nam()
        {
            Console.WriteLine("Введите название устройства");
            Name = Convert.ToString(Console.ReadLine());
        }
    }
    public class Violin : Musicalinstrument
{
        public string Color { set; get; }
        public string Made_in { set; get; }
        public Violin() { }

        public Violin(string C, string M, string N) : base(N)
        {
            Color = C;
            Made_in = M;
        }

        public void Show()
        {
            base.Nam();
        }
        public void Desc()
        {
            Console.WriteLine("Введите цвет скрипки");
            Color = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите место изготовления скрипки");
            Made_in = Convert.ToString(Console.ReadLine());

        }
        public void Sound()
        {
            Console.WriteLine("Скрипка издает звук ------> ПППИИИ");
        }
        public void History()
        {
            Console.WriteLine("Скрипка была создана в 1897 году");
        }
    }
    public class Trombone : Musicalinstrument
    {
        public string Made_in;

        public Trombone() { }
        public Trombone(string Mi, string N) : base(N)
        {
            Made_in = Mi;
        }
        public void Show()
        {
            base.Nam();

        }
        public void Desc()
        {

            Console.WriteLine("Введите место изготовления");
            Made_in = Convert.ToString(Console.ReadLine());

        }
        public void Sound()
        {
            Console.WriteLine("Трамбон издает звук ------> ББББРРРРР");
        }
        public void History()
        {
            Console.WriteLine("Трамбон был создана в 1890 году");
        }
    }
    public class Ukulele : Musicalinstrument
    {
        public string Made_in;
        public string Color;
        public Ukulele() { }
        public Ukulele(string Mi,  string C, string N) : base(N)
        {
            Made_in = Mi;
            
            Color = C;
        }
        public void Show()
        {
            base.Nam();

        }
        public void Desc()
        {

            Console.WriteLine("Введите место изготовления");
            Made_in = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите цвет Укулеля");
            Color = Convert.ToString(Console.ReadLine());

        }
        public void Sound()
        {
            Console.WriteLine("Укулель издает звук ------> БрыньБрынь");
        }
        public void History()
        {
            Console.WriteLine("Укулель был создана в 1967 году");
        }
    }
    public class Cello : Musicalinstrument
    {
        public string Made_in;
        public string Colvo_Strun;
        public Cello() { }
        public Cello(string Mi, string CS, string N) : base(N)
        {
            Made_in = Mi;
            Colvo_Strun = CS;
        }
        public void Show()
        {
            base.Nam();

        }
        public void Desc()
        {

            Console.WriteLine("Введите место изготовления");
            Made_in = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите количесвто струк");
            Colvo_Strun = Convert.ToString(Console.ReadLine());

        }
        public void Sound()
        {
            Console.WriteLine("Виолончель издает звук ------> БРБРБР");
        }
        public void History()
        {
            Console.WriteLine("Виолончель был создана в 1969 году");
        }

    }
}
