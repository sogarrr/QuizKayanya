using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizKayanya
{
    class Program
    {
        static void Main(string[] args)
        {
            Register obj = new Register();
            obj.RegisterAkun();
            Console.ReadLine();


            Login obj1 = new Login();
            obj1.LoginGame();
            Console.ReadLine();
        }
    }
}
