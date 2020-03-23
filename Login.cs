using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizKayanya
{
    class Login
    {
        public void LoginGame()
        {
            string username, password, username1, password1 = string.Empty;
            Console.WriteLine(@" 
 ██████╗ ██╗   ██╗██╗███████╗    ██╗  ██╗ █████╗ ██╗   ██╗ █████╗ ███╗   ██╗██╗   ██╗ █████╗ 
██╔═══██╗██║   ██║██║╚══███╔╝    ██║ ██╔╝██╔══██╗╚██╗ ██╔╝██╔══██╗████╗  ██║╚██╗ ██╔╝██╔══██╗
██║   ██║██║   ██║██║  ███╔╝     █████╔╝ ███████║ ╚████╔╝ ███████║██╔██╗ ██║ ╚████╔╝ ███████║
██║▄▄ ██║██║   ██║██║ ███╔╝      ██╔═██╗ ██╔══██║  ╚██╔╝  ██╔══██║██║╚██╗██║  ╚██╔╝  ██╔══██║
╚██████╔╝╚██████╔╝██║███████╗    ██║  ██╗██║  ██║   ██║   ██║  ██║██║ ╚████║   ██║   ██║  ██║
 ╚══▀▀═╝  ╚═════╝ ╚═╝╚══════╝    ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝
                                                                                        ");
            Console.Write("                                     Masukan Username Anda : ");
            username = Console.ReadLine();
            Console.Write("                                     Masukan Password Anda : ");
            password = Console.ReadLine();

            using (StreamReader sr = new StreamReader(File.Open("Akun.txt", FileMode.Open)))
            {
                username = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();
            }

            if (username == username && password == password)
            {
                Console.WriteLine("Login Sukses");
            }
            else
            {
                Console.WriteLine("Login Gagal");
            }
            Console.Read();
            Console.Clear();
        }
    }
}
