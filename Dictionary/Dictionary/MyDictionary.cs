using System;
using System.Collections.Generic;
using System.Text;

namespace _Dictionary
{
    class MyDictionary<TK, TV>
    {
        TK[] keys;
        TV[] values;

        public MyDictionary()
        {
            keys = new TK[0];
            values = new TV[0];
        }

        public void Add(TK key, TV value)
        {
            TK[] tempKeys = keys;
            TV[] tempValues = values;

            keys = new TK[keys.Length + 1];
            values = new TV[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }


            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            Console.WriteLine("Key: " + key + " Value: " + value + " added to the dictionary!");
        }

        public int Count { get { return keys.Length; } }

    }
}


