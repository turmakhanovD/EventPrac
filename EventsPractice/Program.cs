using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { UserName = "Oleg", Password = "OlegKrutoi123" };
            
            user.PropertyChanged += new MessageSender().SendMessage;
            user.UserName = "Skidan";
            user.Password = "SkidanKrutoi123";

            Console.ReadLine();
        }
    }
}
