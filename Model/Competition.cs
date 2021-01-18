using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Competition
    {
        public List<IParticipant> Participants { get; set; }
        public Queue<Track> Tracks;

        public Competition()
        {
            Tracks = new Queue<Track>();
            Participants = new List<IParticipant>();
        }


        public Track NextTrack()
        {
            if (Tracks.Count == 0)
            {
                Console.WriteLine("queue empty");
                return null;
            }
            return Tracks.Dequeue();
            
          
        }
    }
}

