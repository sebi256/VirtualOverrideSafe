using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualOverrideSafe
{
    class SafeOwner
    {
        private string _valuables = "";
        
        public void ReceiveContents(string safeContents)
        {
            _valuables = safeContents;
            Console.WriteLine($"Thank you for returning my {_valuables}!");
        }
    }
}
