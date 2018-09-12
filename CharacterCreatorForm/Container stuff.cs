using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator_Tutorial
{
    using System.Collections;

    class Container_stuff
    {
       
        public void ArrayExample(int size)
        {
            int[] array = new int[size];
            foreach (var count in array)
            {
                Console.WriteLine(array[count]);
            }

            this.LengthArray(array);
        }

        public void LengthArray(int[] array)
        {
            var it = array.GetEnumerator();
            while (it.MoveNext() != false)
            {
                Console.WriteLine(it.Current);
            }
            int hi = array.Length;
            Console.WriteLine(hi);

        }
    }
}
