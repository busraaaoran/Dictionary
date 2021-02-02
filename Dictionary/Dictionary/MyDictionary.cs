using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
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

            for (int i = 0; i < tempKeys.Length - 1; i++)
            {
                keys[i] = tempKeys[i];
            }


            keys[keys.Length - 1] = key;

            values = new TV[values.Length + 1];

            for (int j = 0; j < values.Length; j++)
            {
                values[j] = tempValues[j];
            }

            values[values.Length - 1] = value;
            Console.WriteLine("Key: " + key + " Value: " + value + " added to the dictionary!");
        }
    }
}

