using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPractice
{
 public delegate void PropertyEventHandler(object sender, PropertyEventArgs args);


    public interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }
}
