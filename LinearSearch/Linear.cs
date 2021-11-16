using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class Linear
    {
        public int linearSearch(int[] arr, int x, int length)
        {
            if(length < 0)
            {
                return -1;
            }
            if(arr[length] == x)
            {
                return length;
            }
           
            return linearSearch(arr, x, length - 1);
           

            
        }
    }
}
