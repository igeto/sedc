using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericSwap<T>
    {
        public T SwapTwoArrays (MyGenericArray<T> arrayOne, MyGenericArray<T> arrayTwo, int length)
        {
            T temp;
            for (int i = 0; i < length; i++)
            {
                temp = arrayOne.ItemInArray(i);
                arrayOne.SetItem(i, arrayTwo.ItemInArray(i));
                arrayTwo.SetItem(i, temp);
            }
            return arrayOne;
        }
    }
}
