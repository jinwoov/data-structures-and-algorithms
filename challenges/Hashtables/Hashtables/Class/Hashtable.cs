﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Class
{
    public class Hashtable
    {

        public int Bucket;

        public LinkedList<Node>[] Table;

        public Hashtable(int size)
        {
            this.Bucket = size;
            this.Table = new LinkedList<Node>[100];
        }

        public void Add(string key, string value)
        {
            int hashedKey = Hash(key);

            if (this.Table[hashedKey] == null)
            {
                Node node = new Node(value);
                LinkedList<Node> ll = new LinkedList<Node>();
                ll.AddFirst(node);
                this.Table[hashedKey] = ll;
            }
            else
            {
                Node node = new Node(value);
                var linkList = this.Table[hashedKey];
                linkList.AddFirst(node);

            }
        }

        public int Hash(string key)
        {
            int sum = 0;
            for (int i = 0; i < key.Length; i++)
            {
                sum += key[i] % Bucket;
            }

            return sum;
        }
    }
}