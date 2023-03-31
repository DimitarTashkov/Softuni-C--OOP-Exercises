﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList<T> : List<T>
    {
        public T RandomString()
        {
            Random random = new Random();

            return this[random.Next(0, Count)];
        }
    }
}
