using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizKayanya
{
    class Register
    {
        public void RegisterAkun()
        {
            string path = "akun.txt";
            Console.WriteLine("Buat Akun Untuk Memainkan : ");

            string username, password = string.Empty;

            Console.Write("Masukan Username Anda : ");
            username = Console.ReadLine();

            Console.Write("Masukan Password Anda : ");
            password = Console.ReadLine();

            File.AppendAllText(path,username + " # " + password + Environment.NewLine);


            Console.WriteLine("Selesai");
            Console.WriteLine("Tekan Apapun Untuk Lanjut");
            Console.Read();
            Console.Clear();
            
        }
    }
}
