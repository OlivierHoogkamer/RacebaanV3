using System;

namespace RacebaanV3
{
    class Program   
    {
        static void Main(string[] args)
        {
            var c = new Model.Competition();

            Controller.Data.Initialize(c);
            
            Visualization.DrawTrack((c.NextTrack()));
            for (; ; )
            {
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
