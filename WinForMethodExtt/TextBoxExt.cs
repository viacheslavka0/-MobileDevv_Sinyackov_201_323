using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinForMethodExtt
{

    
    public static class TextBoxExt
    {
        public static string TextExt (this TextBox s)
        {
            return s.Text.ToUpper() + "!!!";

        }
    }
}
