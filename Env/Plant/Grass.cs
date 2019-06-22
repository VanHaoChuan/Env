using System;

namespace Env.Plant
{
    public class Grass : Plant , IPlant
    {
        public Grass(int _health) : base(_health)
        {
            plantFuncs = this;
            Init();
        }

        public void Grow()
        {
            for (;;)
            {
                if (grownWatch.ElapsedMilliseconds == 10000)
                {
                    age = PlantAge.SEEDLING;
                    Console.WriteLine(grownWatch.ElapsedMilliseconds);
                }
                else if (grownWatch.ElapsedMilliseconds == 25000)
                {
                    eatable = true;
                    age = PlantAge.GROWN;
                    Console.WriteLine(grownWatch.ElapsedMilliseconds);
                }
                else if (grownWatch.ElapsedMilliseconds == 50000)
                {
                    eatable = false;
                    DestroyOrganism();
                }
            }
        }
    }
}