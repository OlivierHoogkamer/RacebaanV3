using System;
using System.Collections.Generic;
using System.Text;
using Model;
namespace Controller
{
    public class Race
    {
        public Track Track;
        public List<IParticipant> Participants;
        public DateTime StartTime;
        private Random _random;

        private Dictionary<Section, SectionData> _positions;

        public Race(Track t, List<IParticipant> p)
        {
            Track = t;
            Participants = p;
            StartTime = new DateTime();
            _random = new Random(DateTime.Now.Millisecond);
        }
        
        public void RandomizeEquipment(List<IParticipant> participants, Random random)
        {
            
            foreach(IParticipant participant in participants)
            {
                participant.Equipment.Quality = random.Next(92,112);
                participant.Equipment.Performance = random.Next(92, 112);
            }
        }

        


        public SectionData GetSectionData(Section s)
        {
           if (_positions.ContainsKey(s))
            {
                return _positions[s];
                
            }
            if (_positions.ContainsKey(s) == false)
            {
                SectionData data = new SectionData();
                _positions.Add(s, data);
                return _positions[s];
            }
            return null;
        }

    }
}
