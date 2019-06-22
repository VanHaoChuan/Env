using System;
using System.Threading.Tasks;
using Env;
using Env.Plant;

namespace StartUp
{
    static class Program
    {
        static void Main(string[] args)
        { 
            Task plantCreatingTask = new Task(() =>
            {
                Grass grass = new Grass(64);
            });
            Task mappingTask = new Task(() =>
            {
                Map map = new Map(4,4);
                map.ShowMap();
            });
            //plantCreatingTask.Start();
            mappingTask.Start();
            Task.WaitAll();
            Console.ReadLine();
        }
    }
}