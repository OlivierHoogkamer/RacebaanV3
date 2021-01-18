using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
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
            Sections = Convert(sections);
            Name = name;

        }

        public LinkedList<Section> Convert(SectionTypes[] st)
        {

            Section startNode = new Section();
            startNode.SectionType = SectionTypes.StartGrid;
            Section endNode = new Section();
            endNode.SectionType = SectionTypes.Finish;

            LinkedListNode<Section> start = new LinkedListNode<Section>(startNode);
            LinkedListNode<Section> end = new LinkedListNode<Section>(endNode);
            LinkedList<Section> lls = new LinkedList<Section>();

            lls.AddFirst(start);
            
            
            foreach (var value in st)
            {
                Section s = new Section();
                if (value == SectionTypes.Straight)
                {
                    s.SectionType = SectionTypes.Straight;
                    LinkedListNode<Section> lln = new LinkedListNode<Section>(s);
                    lls.AddLast(lln);
                }

            }

            lls.AddLast(end);
            return lls;
        }


    }
}
