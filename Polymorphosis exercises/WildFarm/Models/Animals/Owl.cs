﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        private const double OwlMultiplier = 0.25;
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {

        }

        public override double WeightMultiplier => OwlMultiplier;

        public override IReadOnlyCollection<Type> PrefferedFoods => new HashSet<Type> {typeof(Meat) };

        public override string ProduceSound() => "Hoot Hoot";
        
    }
}
