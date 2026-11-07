using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Messeg
{
    internal class Messeger
    {
        public delegate void MyDelegate(string msg);
        public event MyDelegate MessegerReceived;

        public void Mess(string msg)
        {
            MessegerReceived?.Invoke(msg);
        }
    }
}
