using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Env.Plant
{
    public class Grass : Plant , IPlant
    {
        public Grass(int _health) : base(_health)
        {
            plantFuncs = this;
            base.Init();
        }

        public Grass(int _health, int _x, int _y) : base(_health, _x, _y)
        {
            plantFuncs = this;
            base.Init();
        }

        public void Grow()
        {

            Task growTask = new Task(() =>
            {
                for (;;)
                {
                    if (grownWatch.ElapsedMilliseconds == 10000)
                    {
                        age = PlantAge.SEEDLING;
                    }
                    else if (grownWatch.ElapsedMilliseconds == 25000)
                    {
                        eatable = true;
                        age = PlantAge.GROWN;
                    }
                    else if (grownWatch.ElapsedMilliseconds == 50000000)
                    {
                        eatable = false;
                        DestroyOrganism();
                        break;
                    }
                    
                }
            });
            growTask.Start();
        }

        public void Reproduction()
        {

            Task reproductionTask = new Task(() =>
            {
                for (;;)
                {
                    if (age == PlantAge.GROWN && x != 0 && x != 1 && y != 1 && y != 0)
                    {
                        switch (Common.publicRandom.Next(0, 4))
                        {
                            case 1:
                            {
                                Debug.WriteLine("Reprodution");
                                var localGrass = new Grass(_health: health, _x: x - 1, _y: y);
                                map.AddOrganism(localGrass);
                                map.ShowMap();
                                break;
                            }

                            case 2:
                            {
                                Debug.WriteLine("Reprodution");
                                var localGrass = new Grass(_health: health, _x: x - 1, _y: y);
                                map.AddOrganism(localGrass);
                                map.ShowMap();
                                break;
                            }

                            case 3:
                            {
                                Debug.WriteLine("Reprodution");
                                var localGrass = new Grass(_health: health, _x: x - 1, _y: y);
                                map.AddOrganism(localGrass);
                                map.ShowMap();
                                break;
                            }

                            case 4:
                            {
                                Debug.WriteLine("Reprodution");
                                var localGrass = new Grass(_health: health, _x: x - 1, _y: y);
                                map.AddOrganism(localGrass);
                                map.ShowMap();
                                break;
                            }
                        }
                    }
                    System.Threading.Thread.Sleep(500);
                    if (alive == false)
                    {
                        break;
                    }
                }
            });
            reproductionTask.Start();
        }
    }
}