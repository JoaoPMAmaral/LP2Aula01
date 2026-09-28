using System;

namespace CuteAnimal
{
    public class Cat
    {
        private string name;
        private int energy;
        private Mood moodStatus;
        private Feed feedStatus;

        private Random random;

        private Cat()
        {
            random = new Random();
        }

        public Cat(string name, int energy, Mood moodStatus, Feed feedStatus): this()
        {
            this.name = name;
            this.energy = energy;
            this.moodStatus = moodStatus;
            this.feedStatus = feedStatus;
        }

        public Cat(string name): this()
        {
            this.name = name;
            energy = random.Next(1,21);
            moodStatus = (Mood)random.Next(4);
            feedStatus = (Feed)random.Next(5);
        }

        public string GetName()
        {
            return name;
        }
        public int GetEnergy()
        {
            return energy;
        }
        public Mood GetMood()
        {
            return moodStatus;
        }
        public Feed GetFeedStat()
        {
            return feedStatus;
        }
    }
}