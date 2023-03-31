﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        private const double MouseMultiplier = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => MouseMultiplier;

        public override IReadOnlyCollection<Type> PrefferedFoods => new HashSet<Type> { typeof(Vegetable),typeof(Fruit)};

        public override string ProduceSound()
            => "Squeak";

        public override string ToString()
        {
            return base.ToString()+ $"{ Weight}, { LivingRegion}, { FoodEaten}]";
        }

    }
}
