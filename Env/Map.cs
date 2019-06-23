using System;
using System.Diagnostics;

namespace Env
{
    public class Map
    {
        public static int width, length; 
        public static int[,] map;
        public Map(int _width,int _length)
        {
            width = _width * Meter.METER;
            length = _length * Meter.METER;
            map = new int[length,width];
            Array.Clear(map,0,map.Length);
        }
        public void ShowMap()
        {
            for (int variableLength = 0; variableLength < length; variableLength++)
            {
                for (int variableWidth = 0; variableWidth < width; variableWidth++)
                {
                    Console.Write(map[variableLength,variableWidth]);
                    }
                Console.WriteLine("\n");
            }
        }

        public void AddOrganism(Organism organism)
        {
            map[organism.x - 1, organism.y - 1] = 1;
        }
    }
}