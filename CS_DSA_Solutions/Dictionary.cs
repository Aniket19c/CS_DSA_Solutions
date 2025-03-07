using System;
using System.Collections.Generic;

public class MyDictionary<TKey, TValue>
{
    private List<KeyValuePair<TKey, TValue>> items;

    public MyDictionary()
    {
        items = new List<KeyValuePair<TKey, TValue>>();
    }


    public void Add(TKey key, TValue value)
    {
        foreach (var pair in items)
        {
            if (pair.Key.Equals(key))
            {
                throw new ArgumentException("Key already exists in dictionary.");
            }
        }
        items.Add(new KeyValuePair<TKey, TValue>(key, value));
    }

    public TValue Get(TKey key)
    {
        foreach (var pair in items)
        {
            if (pair.Key.Equals(key))
            {
                return pair.Value;
            }
        }
        throw new KeyNotFoundException("Key not found.");
    }

    public bool Remove(TKey key)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].Key.Equals(key))
            {
                items.RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    public bool ContainsKey(TKey key)
    {
        foreach (var pair in items)
        {
            if (pair.Key.Equals(key))
            {
                return true;
            }
        }
        return false;
    }

   
    public void Display()
    {
        foreach (var pair in items)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
}



