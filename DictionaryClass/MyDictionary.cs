using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryClass
{
   
    public class MyDictionary<TKey, TValue>
    {
        // in the dictionary class we had key and value pair so im gonna make type of my variable as TKey and TValue
        
        TKey[] keys;
        TValue[] values;
        
        //im creating constructor to have a place in memory for my arrays.
        public MyDictionary() 
        {
            Console.WriteLine("im going to create my array in Constructor ");
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
        //im creating temporary variables inside of the method. This way its not going to cover too much memory unless its called by the user.--i assume of course--
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
        //im adding enum to use foreach loop.
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
            }
        }
    }
}
