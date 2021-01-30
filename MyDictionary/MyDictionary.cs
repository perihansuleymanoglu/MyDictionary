using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkeys, Tvalues>
    {
        Tkeys[] keys;
        Tvalues[] values;

        public MyDictionary()
        {
            keys = new Tkeys[0];
            values = new Tvalues[0];
        }

        public void Add(Tkeys key, Tvalues value)
        {
            Tkeys[] tempKeys = keys;
            Tvalues[] tempValues = values;

            keys = new Tkeys[keys.Length + 1];
            values = new Tvalues[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public Tkeys[] Keys
        {
            get { return keys; }
        }

        public Tvalues[] Values
        {
            get { return values; }
        }
    }
}
