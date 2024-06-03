using Api.IBPR.Website.Test.DataTest;
using NUnit.Framework;

namespace Api.IBPR.Website.Test.ScheduleTest
{
    [TestFixture]
    public class ScheduleRepositoryTest
    {
        [Test]
        public void Should_return_an_id_schedule()
        {
            var schedule = ScheduleDataExamples.GetSchedule();

            Assert.That(schedule.Id, Is.EqualTo(1));
        }

        [Test]
        public void Should_return_a_day_in_the_schedule()
        {
            var schedule = ScheduleDataExamples.GetSchedule();

            Assert.That(schedule.Day, Is.EqualTo("Sabado"));
        }

        [Test]
        public void Should_return_a_hour_in_the_schedule()
        {
            var schedule = ScheduleDataExamples.GetSchedule();

            Assert.That(schedule.Hour, Is.EqualTo("19:00"));
        }

        [Test]
        public void Should_return_a_title_in_the_schedule()
        {
            var schedule = ScheduleDataExamples.GetSchedule();

            Assert.That(schedule.Title, Is.EqualTo("Aniversario de la Iglesia"));
        }
    }
}