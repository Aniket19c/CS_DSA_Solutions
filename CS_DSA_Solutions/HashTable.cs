using System;
using System.Collections.Generic;

public class HashTable<TKey, TValue>
{
    private const int _size = 10; 
    private LinkedList<KeyValuePair<TKey, TValue>>[] _buckets;

    public HashTable()
    {
        _buckets = new LinkedList<KeyValuePair<TKey, TValue>>[_size];
        for (int i = 0; i < _size; i++)
        {
            _buckets[i] = new LinkedList<KeyValuePair<TKey, TValue>>();
        }
    }


    private int GetBucketIndex(TKey key)    //hash Function to generate hashcode
    {
        int hash = key.GetHashCode();
        return Math.Abs(hash % _size);
    }

   
    public void Add(TKey key, TValue value)
    {
        int index = GetBucketIndex(key);
        var bucket = _buckets[index];

      
        foreach (var pair in bucket)
        {
            if (pair.Key.Equals(key))
            {
                throw new ArgumentException("Key already exists.");
            }
        }

      
        bucket.AddLast(new KeyValuePair<TKey, TValue>(key, value));
    }

   
    public TValue Get(TKey key)
    {
        int index = GetBucketIndex(key);
        var bucket = _buckets[index];

        foreach (var pair in bucket)
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
        int index = GetBucketIndex(key);
        var bucket = _buckets[index];

        foreach (var pair in bucket)
        {
            if (pair.Key.Equals(key))
            {
                bucket.Remove(pair);
                return true;
            }
        }
        return false;
    }


    public bool ContainsKey(TKey key)
    {
        int index = GetBucketIndex(key);
        var bucket = _buckets[index];

        foreach (var pair in bucket)
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
        for (int i = 0; i < _size; i++)
        {
            Console.Write($"Bucket {i}: ");
            foreach (var pair in _buckets[i])
            {
                Console.Write($"[{pair.Key} : {pair.Value}] -> ");
            }
            Console.WriteLine("null");
        }
    }
}



