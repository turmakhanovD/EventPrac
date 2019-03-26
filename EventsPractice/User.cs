using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPractice
{
    public class User : IPropertyChanged
    {
        public event PropertyEventHandler PropertyChanged;
        public string _username;
        public string _password;
        PropertyEventArgs args = new PropertyEventArgs();

        public string UserName
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;

                if (PropertyChanged != null)
                {
                    args.Arg = "UserName";
                    PropertyChanged(this, args);
                }
            }

                
        }
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;

                if (PropertyChanged != null)
                {
                    args.Arg = "Password";
                    PropertyChanged(this, args);
                }
            }


        }
    }
}
    






