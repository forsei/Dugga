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

            if (shortcut.Equals(""))
            {
                throw new ArgumentException("Message is empty.");
            }


            string[] thousand = { "k" };



            return shortcut;



            //if (shortcut > 1000)
            //{
            //    return string.Concat(shortcut / 1000, "k", "K");
            //}
            //else
            //{
            //    return shortcut.ToString();
            //}




            //if (shortcut > 1000000)
            //{
            //    return string.Concat(shortcut / 1000000, "m", "M");
            //}
            //else
            //{
            //    return shortcut.ToString();
            //}




            //if (shortcut > 1000000000)
            //{
            //    return string.Concat(shortcut / 1000000000, "b", "B");
            //}
            //else
            //{
            //    return shortcut.ToString();
            //}


            //if (shortcut > 1000000000000)
            //{
            //    return string.Concat(shortcut / 1000000000000, "t", "T");
            //}
            //else
            //{
            //    return shortcut.ToString();
            //}


            
        }
    }
}
