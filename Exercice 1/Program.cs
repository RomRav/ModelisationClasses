using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double inputBalance;
            Double inputAmount;
            BankAccount CompteLaManu = new BankAccount("", 0, "");
            Console.WriteLine("Merci de saisir le nom du titulaire du compte : ");
            CompteLaManu.titulaire = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Merci de saisir le montant du solde du compte : ");
                if (Double.TryParse(Console.ReadLine(), out inputBalance))
                {
                    CompteLaManu.balance = inputBalance;
                    break;
                }
                else
                {
                    Console.WriteLine("Saisie incorrecte!");
                }          
            }
            Console.WriteLine("Merci de saisir la devise du compte : ");
            CompteLaManu.devise = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Merci de saisir le montant à créditer : ");
                if (Double.TryParse(Console.ReadLine(), out inputAmount))
                {
                    CompteLaManu.credit(inputAmount);
                    break;
                }
                else
                {
                    Console.WriteLine("Saisie incorrecte!");
                }
            }
            Console.WriteLine($"Le solde du compte de {CompteLaManu.titulaire} est de {CompteLaManu.balance} {CompteLaManu.devise}.");
            Console.ReadLine();
        }
    }
}
