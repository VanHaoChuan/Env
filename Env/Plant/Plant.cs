using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Env.Plant
{
    public abstract class Plant : Organism
    {
       
        public enum PlantAge
        {
            SEED,
            SEEDLING,
            GROWN
        } 
        protected static IPlant plantFuncs;
        protected static Stopwatch grownWatch;
        protected int health;
        protected PlantAge age;
        public PlantAge Age => age;
        public bool eatable = false;
        public bool Eatable => eatable;
        protected Map map = Common.map;
        protected Plant(int _health) : base(_health)
        {
            age = PlantAge.SEED;
            grownWatch = new Stopwatch();
        }

        protected Plant(int _health, int _x, int _y) : base(_health, _x, _y)
        {
            age = PlantAge.SEED;
            grownWatch = new Stopwatch();
        }

        public void Init()
        {
            grownWatch.Start();
            plantFuncs.Grow();
            plantFuncs.Reproduction();
        }

        protected new void DestroyOrganism()
        {
            base.DestroyOrganism();
            eatable = false;
            plantFuncs = null;
            grownWatch.Stop();
        }
    }
}