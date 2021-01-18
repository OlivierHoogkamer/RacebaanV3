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
                CurrentRace = new Race(c.NextTrack(), c.Participants);
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
                SectionTypes[] t1 = new SectionTypes[5];
                t1[0] = SectionTypes.Straight;
                t1[1] = SectionTypes.Straight;
                t1[2] = SectionTypes.Straight;
                t1[3] = SectionTypes.Straight;
                t1[4] = SectionTypes.Straight;
                

                var Track1 = new Track("Zandvoort", t1);
                var Track2 = new Track("Abu Dhabi", t1);
                var Track3 = new Track("Monaco", t1);

                
                c.Tracks.Enqueue(Track1);
                c.Tracks.Enqueue(Track2);
                c.Tracks.Enqueue(Track3);
                
            }
        }
    } 

