using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Raml.Parser.Expressions
{
    public class RamlTypesOrderedDictionary
    {
        private readonly List<KeyValuePair<string, RamlType>> dic = new List<KeyValuePair<string, RamlType>>();
        public int Count { get { return dic.Count; } }

        public void Clear()
        {
            dic.Clear();
        }

        public List<string> Keys { get { return dic.Select(kv => kv.Key).ToList(); } }

        public List<KeyValuePair<string, RamlType>>.Enumerator GetEnumerator()
        {
            return dic.GetEnumerator();
        }

        public void Add(string key, RamlType value)
        {
            if(ContainsKey(key))
                throw new InvalidOperationException("Key already exists: " + key);

            dic.Add(new KeyValuePair<string, RamlType>(key, value));
        }

        public RamlType GetByKey(string key)
        {
            if (!ContainsKey(key))
                return null;

            var type = dic.FirstOrDefault(kv => kv.Key == key);
            return type.Value;
        }

        public bool ContainsKey(string key)
        {
            return dic.Any(kv => kv.Key == key);
        }

        public RamlType this[string key]
        {
            get { return GetByKey(key); }
        }
    }
}