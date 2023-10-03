using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private string favoriteFood;

        public Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;
        }

        public string Name
        {
            get => name;
            private set => name = value;
        }

        public string FavoriteFood
        {
            get => favoriteFood;
            private set => name = value;
        }

        public abstract string ExplainSelf();
    }
}
