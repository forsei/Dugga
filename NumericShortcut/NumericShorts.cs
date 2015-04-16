using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericShortcut
{
    public class NumericShorts : INumericShortcut
    {
        public string ChangeNumericShortcut(string shortcut)
        {
            if (shortcut == null)
            {
                throw new ArgumentNullException("Message is null");
            }

            if (shortcut.Trim().Equals(""))
            {
                throw new ArgumentException("Message is empty.");
            }



            return "1000";
        }
    }
}
