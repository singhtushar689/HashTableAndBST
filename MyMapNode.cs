﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST
{
    internal class MyMapNode<K, V>
    {
        private int size;
        private LinkedList<KeyValue<K, V>>[] items;
        /// <summary>
        /// constructor of the class to crate an object of that class
        /// </summary>
        /// <param name="size"></param>
        public MyMapNode(int size)
        {
            this.size = size;
            items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        /// <summary>
        /// add fun to Add the key-value pair in a node of LinkedList
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="value"></param>
        public void Add(K Key, V value)
        {
            int position = GetArrayPosition(Key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = Key, Value = value };
            linkedlist.AddLast(item);
        }
        /// <summary>
        /// o find the exact position of a Node in LinkedList
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
        /// <summary>
        /// find the index key of Hash table
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default;
        }
    }
}
