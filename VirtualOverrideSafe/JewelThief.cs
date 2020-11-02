using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualOverrideSafe
{
    class JewelThief : Locksmith
    {
        private string _stolenJewels;
        protected override void ReturnContents(string safeContents, SafeOwner owner)
        {
            _stolenJewels = safeContents;
            Console.WriteLine($"I'm steeling the jewels. I stole {_stolenJewels}");
        }
    }
}
