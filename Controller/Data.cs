using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Controller
{
    public static class Data
    {
        public static Competition competition;
        public static Race CurrentRace;

        public static void Initialize(Competition competition)
        {

            AddParticipants(competition);
            AddTrack(competition);

        }
        public static void NextRace(Competition c)
        {
            if (c.Tracks != null)
            {
                CurrentRace = new Race(c.NextTrack(c), c.Participants);
            }
            
        }



            public static void AddParticipants(Competition c)
            {
                var Driver1 = new Driver("Bart", 0, TeamColors.Green);
                var Driver2 = new Driver("Klaas", 0, TeamColors.Blue);
                var Driver3 = new Driver("John", 0, TeamColors.Red);
                c.Participants.Add(Driver1);
                c.Participants.Add(Driver2);
                c.Participants.Add(Driver3);
            }
            public static void AddTrack(Competition c)
            {
                var Track1 = new Track("Zandvoort");
                var Track2 = new Track("Abu Dhabi");
                var Track3 = new Track("Monaco");

                
                c.Tracks.Enqueue(Track1);
                c.Tracks.Enqueue(Track2);
                c.Tracks.Enqueue(Track3);
                
            }
        }
    } 

