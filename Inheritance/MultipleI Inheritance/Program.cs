﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class StartUp
    {
       public static void Main()
        {
            Puppy puppy = new Puppy();

            puppy.Eat();

            puppy.Bark();

            puppy.Weep();

        }
    }
}