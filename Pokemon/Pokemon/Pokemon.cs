using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokemon
    {
        private string _PokeNames; // Holds Pokemon Names
        private int SIZE = 16;
        private int _AttackVar;
        private string _AttackName;

        public string PokemonName
        {
            get { return _PokeNames; }
            set { _PokeNames = value; }
        }

        public int AttackVar
        {
            get { return _AttackVar; }
            set { _AttackVar = value; }
        }

        public string Attack
        {
            get { return _AttackName; }
            set { _AttackName = value; }
        }

        public Pokemon(string PokeName, int AttackVar, string Attack)
        {
            _PokeNames = PokeName;
            _AttackVar = AttackVar;
            _AttackName = Attack;

        }
    }
}
