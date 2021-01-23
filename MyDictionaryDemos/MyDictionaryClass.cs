using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemos
{
    class MyDictionaryClass<T, K>
    {
        T[] ArrayKey;
        K[] ArrayVal;

        T[] TempKey;
        K[] TempVal;

        public MyDictionaryClass()
        {

            ArrayKey = new T[0];
            ArrayVal = new K[0];

        }
        public void Add(T item, K value)
        {
            TempKey = ArrayKey;
            TempVal = ArrayVal;

            ArrayKey = new T[ArrayKey.Length + 1];
            ArrayVal = new K[ArrayVal.Length + 1];

            for (int i = 0; i < TempKey.Length; i++)
            {

                ArrayKey[i] = TempKey[i];
            }
            for (int i = 0; i < TempVal.Length; i++)
            {
                ArrayVal[i] = TempVal[i];
            }

                ArrayKey[ArrayKey.Length - 1] = item;
                ArrayVal[ArrayVal.Length - 1] = value;

                Output(ArrayKey, ArrayVal);
        }
        public void Output(T[] Arraykey, K[] ArrayVal)
        {

            for (int i = 0; i < Arraykey.Length; i++)
            {

                Console.WriteLine(" Ürün : " + Arraykey[i] +  " Fiyat : " + ArrayVal[i]);

            }


        }

    }
} 