using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryClass
{
   
    public class MyDictionary<TKey, TValue>
    {
        
        TKey[] keys;
        TValue[] values;
        public MyDictionary() 
        {
            Console.WriteLine("we are going to create our array in Constructor ");
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = keys;
            TValue[] tempValue = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i]; 
            }
            
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
            }
        }
    }
}
