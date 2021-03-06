using System;

namespace ConsoleApp1
{
    class Program
    {
        enum Wybor
        {
            Nic = -1,
            Wyjdz = 0,
            Temperatura = 1,
            Dlugosc = 2,
            Masa = 3
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Konwerter jednostek");
            Wybor wybór = Wybor.Nic;

            while (false == wybór.Equals(Wybor.Wyjdz))
            {
                Console.WriteLine("Wybierz od 1 do 3 co chcesz zrobic i zatwierdź enterem\n");
                Console.WriteLine("0. Wyjdz");
                Console.WriteLine("1.Konwersja Temperatury");
                Console.WriteLine("2.Konwersja Długości");
                Console.WriteLine("3.Konwersja Masy");
                wybór = (Wybor) int.Parse(Console.ReadLine());
                Console.Clear();

                switch (wybór)
                {
                    case Wybor.Temperatura:
                        Temperatura();
                        break;
                    case Wybor.Dlugosc:
                        Długość();
                        break;
                    case Wybor.Masa:
                        Masa();
                        break;
                }
            }
        }

        static void Temperatura()
        {
            Console.WriteLine("Wybierz od 1 do 2 co chcesz zrobic i zatwierdź enterem\n");
            Console.WriteLine("1.Fahrenheit na Celsius");
            Console.WriteLine("2.Celsius na Fahrenheit");
            var wybór = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (wybór)
            {
                case 1:
                    z_fahrenheita_do_celsiusza();
                    break;
                case 2:
                    z_celsiusza_do_farenhaita();
                    break;
            }

            Console.Clear();
        }

        private static void z_celsiusza_do_farenhaita()
        {
            double Fahrenheit, Celsius;
            Console.WriteLine("Podaj temperature w stopniach celsiusa");
            Celsius = double.Parse(Console.ReadLine());
            Fahrenheit = (Celsius * 9) / 5 + 32;
            Console.WriteLine(Fahrenheit);
            Console.ReadKey();
        }

        private static void z_fahrenheita_do_celsiusza()
        {
            double Fahrenheit, Celsius;
            Console.WriteLine("Podaj temperature w stopniach fahrenheita");
            Fahrenheit = double.Parse(Console.ReadLine());
            Celsius = 5.0 / 9 * (Fahrenheit - 32);
            Console.WriteLine(Celsius);
            Console.ReadKey();
        }

        static void Długość()
        {
            Console.WriteLine("Wybierz od 1 do 2 co chcesz zrobic i zatwierdź enterem\n");
            Console.WriteLine("1.Kilometr na Mila");
            Console.WriteLine("2.Mila na Kilometr");
            int wybór = Int32.Parse(Console.ReadLine());
            Console.Clear();

            switch (wybór)
            {
                case 1:
                    z_kilometrow_na_mile();
                    break;
                case 2:
                    z_mil_na_kilometry();
                    break;
            }

            Console.Clear();
        }

        private static void z_mil_na_kilometry()
        {
            double Kilometr, Mila;
            Console.WriteLine("Podaj długość w milach:");
            Mila = double.Parse(Console.ReadLine());
            Kilometr = 1.609 * Mila;
            Console.WriteLine(Kilometr);
            Console.ReadKey();
        }

        private static void z_kilometrow_na_mile()
        {
            double Kilometr, Mila;
            Console.WriteLine("Podaj długość w kilometrach:");
            Kilometr = double.Parse(Console.ReadLine());
            Mila = 0.62137 * Kilometr;
            Console.WriteLine(Mila);
            Console.ReadKey();
        }

        static void Masa()
        {
            Console.WriteLine("Wybierz od 1 do 2 co chcesz zrobic i zatwierdź enterem\n");
            Console.WriteLine("1.Kilogram na Funt");
            Console.WriteLine("2.Funt na Kilogram");
            int wybór = Int32.Parse(Console.ReadLine());
            Console.Clear();

            switch (wybór)
            {
                case 1:
                    z_kilogramow_na_funty();
                    break;
                case 2:
                    z_funtow_na_kilogramy();
                    break;
            }

            Console.Clear();
        }

        private static void z_funtow_na_kilogramy()
        {
            double Kilogram, Funt;
            Console.WriteLine("Podaj mase w funtach:");
            Funt = double.Parse(Console.ReadLine());
            Kilogram = (Funt * 0.450);
            Console.WriteLine(Kilogram);
            Console.ReadKey();
        }

        private static void z_kilogramow_na_funty()
        {
            double Kilogram, Funt;
            Console.WriteLine("Podaj mase w kilogramach:");
            Kilogram = double.Parse(Console.ReadLine());
            Funt = 2.2046 * Kilogram;
            Console.WriteLine(Funt);
            Console.ReadKey();
        }
    }
}