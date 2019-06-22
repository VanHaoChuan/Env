namespace Env.Animals
{
    public abstract class Animal : Organism
    {
        private int thirst;
        private int hunger;

        public Animal(int _hunger, int _thirst, int _health) : base(_health)
        {
            hunger = _hunger;
            thirst = _thirst;
        }

        protected abstract void Foraging();
    }
}