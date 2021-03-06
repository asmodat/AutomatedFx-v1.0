﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Concurrent;

using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;

namespace Asmodat.Abbreviate
{
    public partial class ThreadedList<T> : List<T>
    {
        public new T this[int index]
        {
           
             get { lock (this) return this.ElementAt(index); }
             set { lock (this) base[index] = value; } //fixed ?
       
        }

        public T[] ValuesArray { get { lock (this) return this.ToArray(); } }
        public List<T> ValuesList { get { lock (this) return this.ToList(); } }


        public new void Add(T item)
        {
            lock (this)
                base.Add(item);
        
        }

        public new void AddRange(IEnumerable<T> collection)
        {
            this.AddRange(collection);
        }

        public void AddRange(params T[] items)
        {
            if (items == null || items.Length <= 0) return;

            lock (this)
            {
                int i = 0;
                for (; i < items.Length; i++)
                    base.Add(items[i]);
            }
        }

        public new void Clear()
        {
            lock (this)
                base.Clear();
        }
    }
}
