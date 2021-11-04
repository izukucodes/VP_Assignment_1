using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MyArrayList : ArrayList
    {
        public override void Remove(Object a)
        {
            while (base.Contains(a))
            {
                base.Remove(a);
            }
        }
    }
}
