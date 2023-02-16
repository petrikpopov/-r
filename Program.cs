using System;

namespace HM13._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            //////////////////////////////

            /*int p;
            Console.WriteLine("Выберите способ оплаты:\t1)Гривна,2)Долар,3)Евро\n");
            Products obj = new Products();
            p = Convert.ToInt32(Console.ReadLine());
            if (p==1)
            {
                obj.G();
            }
            if (p==2)
            {
                obj.D();
            }
            if (p==3)
            {
                obj.E();
            }*/

            //////////////////////////////

            /*Chainik obj = new Chainik();
            obj.Show();
            obj.Desc();
            obj.Sound();
            Console.WriteLine("\n");
            Microvolnovka obj1 = new Microvolnovka();
            obj1.Show();
            obj1.Desc();
            obj1.Sound();
            Console.WriteLine("\n");
            Car obj2 = new Car();
            obj2.Show();
            obj2.Desc();
            obj2.Sound();
            Console.WriteLine("\n");
            Parohod obj3 = new Parohod();
            obj3.Show();
            obj3.Desc();
            obj3.Sound();*/

            /////////////////////////////////

            Violin obj = new Violin();
            obj.Show();
            obj.Desc();
            obj.Sound();
            obj.History();
            Console.WriteLine("\n");
            Trombone ob1 = new Trombone();
            ob1.Show();
            ob1.Desc();
            ob1.Sound();
            ob1.History();
            Console.WriteLine("\n");
            Ukulele obj1 = new Ukulele();
            obj1.Show();
            obj1.Desc();
            obj1.Sound();
            obj1.History();
            Console.WriteLine("\n");
            Cello obj2 = new Cello();
            obj2.Show();
            obj2.Desc();
            obj2.Sound();
            obj2.History();
            Console.WriteLine("\n");
        }
    }
}
