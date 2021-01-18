using Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerTest
{
    [TestFixture]
    public class Model_Competition_NextTrackShould
    {
        private Competition _competition;

        [SetUp]
        public void SetUp()
        {
            _competition = new Competition();
        }
        [Test]
        public void NextTrack_EmptyQueue_ReturnNull()
        {
           var result = _competition.NextTrack();
           Assert.IsNull(result);
        }
        [Test]
        public void NextTrack_OneInQueue_ReturnTrack()
        {
            SectionTypes[] t1 = new SectionTypes[5];
            t1[0] = SectionTypes.Straight;
            t1[1] = SectionTypes.Straight;
            t1[2] = SectionTypes.Straight;
            t1[3] = SectionTypes.Straight;
            t1[4] = SectionTypes.Straight;
            Track t21 = new Track("Zandvoort", t1);
            _competition.Tracks.Enqueue(t21);
            Track result = _competition.NextTrack();
            Assert.AreEqual( t21, result);

        }

        [Test]
        public void NextTrack_OneInQueue_RemoveTrackFromQueue()
        {
            SectionTypes[] t1 = new SectionTypes[5];
            t1[0] = SectionTypes.Straight;
            t1[1] = SectionTypes.Straight;
            t1[2] = SectionTypes.Straight;
            t1[3] = SectionTypes.Straight;
            t1[4] = SectionTypes.Straight;
            Track t21 = new Track("Zandvoort",t1);
            _competition.Tracks.Enqueue(t21);
            var result = _competition.NextTrack();
            var result2 = _competition.NextTrack();

            Assert.IsNull(result2);
        }

        [Test]
        public void NextTrack_TwoInQueue_ReturnNextTrack()
        {
            SectionTypes[] t1 = new SectionTypes[5];
            t1[0] = SectionTypes.Straight;
            t1[1] = SectionTypes.Straight;
            t1[2] = SectionTypes.Straight;
            t1[3] = SectionTypes.Straight;
            t1[4] = SectionTypes.Straight;
            Track t21 = new Track("Zandvoort", t1);
            _competition.Tracks.Enqueue(t21);
            Track t31 = new Track("Monaco", t1);
            _competition.Tracks.Enqueue(t31);

            Assert.AreEqual(_competition.NextTrack(), t21);
            Assert.AreEqual(_competition.NextTrack(), t31);

        }
    }
}
