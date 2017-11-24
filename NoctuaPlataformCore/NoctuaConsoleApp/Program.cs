using NoctuaCore;
using NoctuaCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoctuaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User("Alécio","Souza",DateTime.Now,"aleciogomessouza@gmail.com","123456789");

            /*User user = new User();

            Console.Write("Nome: ");
            user.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Sobrenome: ");
            user.Sobrenome = Console.ReadLine();
            Console.WriteLine();

            user.DtNasc = DateTime.Now;

            Console.Write("Email: ");
            user.Email = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Senha: ");
            user.Password = Console.ReadLine();
            Console.WriteLine();*/

            UserRepositoryFirebase userRepositoryFirebase = new UserRepositoryFirebase();

            userRepositoryFirebase.Insert(user);
            Console.WriteLine("OK");
            Console.Read();

        }
    }
}
