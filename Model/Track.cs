using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Track
    {
        public string Name { get; set; }
        public LinkedList<Section> Sections;

        public Track(string name, SectionTypes[] sections)
        {
            Sections = new LinkedList<Section>();
        }
        public Track(string name)
        {
            Name = name;
        }

        public Track()
        {
        }
    }
}
