using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace RacebaanV3
{
    public static class Visualization
    {
        public static void Initialize()
        {

        }

        #region graphics

        private static string[] _finishHorizontal = {"####", "####", "####", "####"};
        private static string[] _startHorizontal = { "----", "  # ", "  # ", "----" };
        private static string[] _horizontal = { "----", "   ", "   ", "----" };
        private static string[] _reserved = { "####", "  # ", "  # ", "####" };

        #endregion

        public static void DrawTrack(Track t)
        {
            Console.WriteLine("Huidige circuit:");
            Console.WriteLine(t.Name);
            foreach (var section in t.Sections)
            {
                if (section.SectionType == SectionTypes.StartGrid)
                {
                    Console.WriteLine(String.Concat(_startHorizontal));
                }
                if (section.SectionType == SectionTypes.Finish)
                {
                    Console.WriteLine(String.Concat(_finishHorizontal));
                }
                if (section.SectionType == SectionTypes.Straight)
                {
                    Console.WriteLine(String.Concat(_horizontal));
                }
                
            }
        }
    }
}


