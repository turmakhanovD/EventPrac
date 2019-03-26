using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPractice
{
    public class MessageSender
    {
       public void SendMessage(object sender, PropertyEventArgs args)
       {
           if (args.Arg == "UserName")
           {
               Console.WriteLine("UserName изменено");
           }
           else if (args.Arg == "Password")
           {
               Console.WriteLine("Password изменено");
           }

       }
    }
}



