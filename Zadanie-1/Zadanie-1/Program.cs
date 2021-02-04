using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator pól figur \n");


            //Prostokąt
            Console.WriteLine("Pole prostokąta \n");
            Console.WriteLine("Podaj krótszy bok prostokąta \n");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj dłuższy bok prostokąta \n");
            int b = int.Parse(Console.ReadLine());

            int pole = 0;

            pole = (a * b);


            Console.WriteLine("Pole prostokąta wynosi: " + pole + "\n");

            //kwadrat
            Console.WriteLine("Pole kwadratu \n");
            Console.WriteLine("Podaj długość boku kwadratu:  \n");
            int c = int.Parse(Console.ReadLine());

            int pole2 = (c * c);
            Console.WriteLine("Pole kwadratu wynosi: " + pole2 + "\n");


            //równoległobok
            Console.WriteLine("Pole równoległoboku \n");
            Console.WriteLine("Podaj długość boku równoległoboku:  \n");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokość równoległoboku:  \n");
            int h1 = int.Parse(Console.ReadLine());

            int pole3 = (d * h1);
            Console.WriteLine("Pole równoległoboku wynosi: " + pole3 + "\n");


            //romb
            Console.WriteLine("Pole rombu \n");
            Console.WriteLine("Podaj długość boku rombu:  \n");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokość rombu:  \n");
            int h2 = int.Parse(Console.ReadLine());

            int pole4 = (e * h2);
            Console.WriteLine("Pole rombu wynosi: " + pole4 + "\n");

            //zakończenie
            Console.WriteLine("W celu zakońćzenia kliknij dowolny klawisz  \n");
            Console.ReadKey();








        }
        
    }
}
