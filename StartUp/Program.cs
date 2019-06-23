using System;
using System.Threading.Tasks;
using Env;
using Env.Plant;

namespace StartUp
{
    public static class Program
    {
        static void Main(string[] args)
        { 
            Task plantCreatingTask = new Task(() =>
            {
                Grass grass = new Grass(64);
            });
            Task mappingTask = new Task(() =>
            {
                Grass grass = new Grass(64, 20, 3);
                Common.map.AddOrganism(grass);
                for (;;) 
                {
                    Console.Clear();
                    Common.map.ShowMap();
                    System.Threading.Thread.Sleep(20);
                }
            });
            //plantCreatingTask.Start();
            mappingTask.Start();
            Task.WaitAll();
            Console.ReadLine();
        }
    }
}