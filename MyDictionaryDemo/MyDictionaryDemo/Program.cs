using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("1.Day", "C#");
            dictionary.Add("2.Day", "Java");
            dictionary.Add("3.Day", "C");
            dictionary.Add("4.Gün", "Angular");

            foreach (var keys in dictionary.Key)
            {
                Console.WriteLine(keys);
            }

            Console.WriteLine("----------");

            foreach (var values in dictionary.Value)
            {
                Console.WriteLine(values);
            }

            Console.WriteLine("----------");

            Console.WriteLine(dictionary.Length);
        }
    }
    class MyDictionary<TKey, TValue>
    {
        private TKey[] _key;
        private TKey[] _tempKey;
        private TValue[] _value;
        private TValue[] _tempValue;


        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempKey = _key;
            _tempValue = _value;

            _key = new TKey[_key.Length + 1];
            _value = new TValue[_value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
                _value[i] = _tempValue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;

        }


        public int Length
        {
            get { return _key.Length; }
        }

        public TKey[] Key
        {
            get { return _key; }

        }

        public TValue[] Value
        {
            get { return _value; }

        }


    }
}
