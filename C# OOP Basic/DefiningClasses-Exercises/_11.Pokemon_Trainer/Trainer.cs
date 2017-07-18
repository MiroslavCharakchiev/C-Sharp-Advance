using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Pokemon_Trainer
{
    class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfBadges
        {
            get
            {
                return this.numberOfBadges;
            }
            set
            {
                this.numberOfBadges = value;
            }
        }

        public List<Pokemon> Pokemons
        {
            get
            {
                return this.pokemons;
            }
            set
            {
                this.pokemons = new List<Pokemon>();
            }
        }

        public Trainer(string name, Pokemon pokemon)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
            this.Pokemons.Add(pokemon);
        }
    }
}
