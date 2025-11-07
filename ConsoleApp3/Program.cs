namespace ConsoleApp12
{
    public class KontoBankowe
    {
        public decimal saldo { get; set; }
        string numerKonta { get; }

        public KontoBankowe(decimal s, string n)
        {
            saldo = s;
            numerKonta = n;
        }

        public void dzialanie(int Operacja, decimal kwota)
        {
            Console.Clear();
            switch (Operacja)
            {
                case 1:
                    bool wpl = wplata(kwota);
                    Console.WriteLine($"stan operacji: {wpl}");
                    Console.WriteLine($"stan konta {numerKonta} po dodaniu: {saldo}");
                    Console.WriteLine();
                    Console.WriteLine("Wcisnij Enter aby kontynuowac..."); Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Aktualny stan konta: " + saldo);
                    break;
                case 2:
                    bool wypl = wyplata(kwota);
                    Console.WriteLine($"stan operacji: {wypl}");
                    Console.WriteLine($"stan konta {numerKonta} po dodaniu: {saldo}");
                    Console.WriteLine();
                    Console.WriteLine("Wcisnij Enter aby kontynuowac..."); Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Aktualny stan konta: " + saldo);
                    break;
                case 3:
                    Console.WriteLine("Dziekujemy za skorzystanie z naszego banku. Do zobaczenia w krotce");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Podano niepoprawna instrukcje (bledny numer)");
                    Console.WriteLine();
                    Console.WriteLine("Wcisnij Enter aby kontynuowac..."); Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Aktualny stan konta: " + saldo);
                    break;
            }
        }

        public bool wplata(decimal kwota)
        {
            if (kwota > 0)
            {
                saldo += kwota;
                return true;
            }
            else return false;
        }
        public bool wyplata(decimal kwota)
        {
            if (kwota > 0 && saldo - kwota >= 0)
            {
                saldo -= kwota;
                return true;
            }
            else return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe kb1 = new KontoBankowe(10000, "123-456-789");
            while(true)
            {
                Console.WriteLine("wprowadz kwote: "); string KwotaStr = Console.ReadLine();
                decimal kwota = decimal.Parse(KwotaStr);
                Console.WriteLine("wplac(1), wyplac(2), wyloguj(3)"); string OperacjaStr = Console.ReadLine();
                int Operacja = int.Parse(OperacjaStr);
                kb1.dzialanie(Operacja, kwota);
            }

        }
    }
}