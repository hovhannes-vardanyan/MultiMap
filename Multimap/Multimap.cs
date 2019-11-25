using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMap
{
    class Multimap<T1, T2> : IDictionary
    {
        
        Dictionary<T1, List<T2>> multimap = new Dictionary<T1, List<T2>>();
        //def constructor
        public Multimap()
        {

        } 
        //constructor
        public Multimap(T1 key, List<T2> values)
        {
            multimap.Add(key,values);
        }
        // indexer
        public object this[object key]
        {
            get
            {
                if (key is int)
                {
                    int Key = (int)key;
                    return multimap.ElementAt(Key);
                }
                else
                {
                    return null;
                }

            }
            set
            {
                if (key is T1)
                {
                    int Key = (int)key;
                    multimap.ElementAt(Convert.ToInt32(Key)).Equals(value);
                }

            }

        }

        // veradarcnume Key-eri zangvac
        public ICollection Keys
        {
            get
            {
                return multimap.Keys;
            }

        }
        // veradarcnume Value-neri zangvac
        public ICollection Values
        {
            get
            {
                //for (int i = 0; i < length; i++)
                //{

                //}
                return multimap.Values;
            }

        }

        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public int Count()
        {
            return multimap.Count;
        }

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        int ICollection.Count => ((IDictionary)multimap).Count;

        public void Add(object key, object value)
        {
            if (key is T1 && value is List<T2>) // casting
            {
                T1 Key = (T1)key;
                List<T2> Value = (List<T2>)value;
                multimap.Add(Key, Value);
            }

        }

        public void Clear()
        {
            multimap.Clear();
        }

        public bool Contains(object key)
        {
            if (key is T1) // casting
            {
                T1 Key = (T1)key;
                return multimap.ContainsKey(Key);
            }
            else
            {
                return false;
            }
        }

        // Chem koxmnoroshvel 
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            return multimap.GetEnumerator();
        }

        public void Remove(object key)
        {
            if (key is T1)
            {
                T1 Key = (T1)key;
                multimap.Remove(Key);
            }

        }

        /// <summary>
        /// Tpum e Multimapi Bolor Andamnery
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < this.multimap.Keys.Count; i++)
            {
                for (int j = 0; j < this.multimap.Values.ElementAt(i).Count; j++)
                {
                  Console.Write($"[{this.multimap.Keys.ElementAt(i)}: {multimap.Values.ElementAt(i)[j]}]");
                    
                }
                Console.WriteLine();
            }
        }

       
        IEnumerator IEnumerable.GetEnumerator()
        {
            return multimap.GetEnumerator();
        }
    }
}
