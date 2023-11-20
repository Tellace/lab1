using System.Collections.Generic;

namespace AnimalApp
{
    internal class AnimalAdapter
    {
        public AnimalAdapter(MainActivity mainActivity, List<Animal> animals)
        {
            MainActivity = mainActivity;
            Animals = animals;
        }

        public MainActivity MainActivity { get; }
        public List<Animal> Animals { get; }
    }
}