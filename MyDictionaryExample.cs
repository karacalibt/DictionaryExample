using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    public class MyDictionaryExample<TKey,  TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionaryExample()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    throw new ArgumentException("Aynı anahtar zaten mevcut.");
                }
            }

            TKey[] tempKeys = new TKey[keys.Length + 1];
            TValue[] tempValues = new TValue[values.Length + 1];

            for (int i = 0; i < keys.Length; i++)
            {
                tempKeys[i] = keys[i];
                tempValues[i] = values[i];
            }

            tempKeys[keys.Length] = key;
            tempValues[values.Length] = value;

            keys = tempKeys;
            values = tempValues;
        }

        public int Count
        {
            get { return keys.Length; }
        }
    }
}
