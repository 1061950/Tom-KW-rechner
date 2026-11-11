using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_KW_rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PSzahl;
            int KWzahl;
            int a;
            int b;
            Console.WriteLine("1. PS in KW umrechnen");
            Console.WriteLine("2. Fläche eines Rechtecks berechnen");
            Console.WriteLine("3. Volumen einer Pyramide berechnen");
            Console.WriteLine("4. Volumen eines Zylinders berechnen");

            int eingabe = Convert.ToInt32(Console.ReadLine());
            //char eingabe = Console.ReadKey().KeyChar;
            switch (eingabe)
            {
                case 1:
                    Console.WriteLine("Geben sie die PS-Zahl ein :)");
                    PSzahl = Convert.ToInt32(Console.ReadLine());
                    KWzahl = Convert.ToInt32(PSzahl * 0.7457);
                    Console.WriteLine($"Die KW-Zahl ist: {KWzahl}");
                    break;
                case 2:
                    Console.WriteLine("Geben sie die Länge & Höhe der Seiten des Rechtecks ein :)");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Die Fläche des Rechtecks ist: {a * b}");
                    break;
                case 3:
                    Console.WriteLine("Geben sie die Länge & Höhe der Seiten des Rechtecks ein :)");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Die Fläche des Rechtecks ist: {a * b}");
                    break;
                case 4:
                    Console.WriteLine("Geben sie die Radius & Höhe des Zylinders ein :)");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Das Volumen des Zylinders ist: {2 * Math.PI * a * a + 2 * Math.PI * a * b}");
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;
            }
            /*
                        if (
                            Console.ReadLine() == "ps" ||
                            Console.ReadLine() == "Ps" ||
                            Console.ReadLine() == "PS"
                            )
                        {

                            Console.WriteLine("Geben sie die PS-Zahl ein :)");

                            PSzahl = Convert.ToInt32(Console.ReadLine());
                            KWzahl = Convert.ToInt32(PSzahl * 0.7457);
                            Console.WriteLine($"Die KW-Zahl ist: {KWzahl}");
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////////
                        if (
                            Console.ReadLine().ToLower() == "rechteck"
                            )
                        {
                            Console.WriteLine("Geben sie die Länge & Höhe der Seiten des Rechtecks ein :)");
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Die Fläche des Rechtecks ist: {a * b}");
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////////
                        if (Console.ReadLine().ToLower() == "pyramide")
                        {
                           Console.WriteLine("Geben sie die Länge & Höhe der Seiten des Rechtecks ein :)");
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Die Fläche des Rechtecks ist: {a * b}");
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////////
                        if (Console.ReadLine().ToLower() == "zylinder")
                        {
                            Console.WriteLine("Geben sie die Radius & Höhe des Zylinders ein :)");
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Das Volumen des Zylinders ist: {2 * Math.PI * a * a + 2 * Math.PI * a * b}");
                        }
            */
        }
    }
}
