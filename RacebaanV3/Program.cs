using System;

namespace RacebaanV3
{
    class Program   
    {
        static void Main(string[] args)
        {
            var c = new Model.Competition();
            Controller.Data.Initialize(c);
            Controller.Data.NextRace(c);
            Console.WriteLine(Controller.Data.CurrentRace.Track.Name);
            Controller.Data.NextRace(c);
            Console.WriteLine(Controller.Data.CurrentRace.Track.Name);

            for (; ; )
            {
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
