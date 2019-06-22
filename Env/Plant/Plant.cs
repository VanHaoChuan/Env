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
        protected PlantAge age;
        public PlantAge Age => age;
        public bool eatable = false;
        public bool Eatable => eatable;
        public Plant(int _health) : base(_health)
        {
            age = PlantAge.SEED;
            grownWatch = new Stopwatch();
        }

        public void Init()
        {
            grownWatch.Start();
            plantFuncs.Grow();
            x = Common.publicRandom.Next(Map.length);
            y = Common.publicRandom.Next(Map.width);
        }
    }
}