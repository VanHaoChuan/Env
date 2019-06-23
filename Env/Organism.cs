namespace Env
{
    public abstract class Organism
    {
        protected bool alive;
        private int health;
        public int x, y;
        enum Kingdom
        {
        }
        enum Phylum
        {
        }
        enum Class
        {
        }

        enum Order
        {
        }

        enum Family
        {
        }

        enum Genus
        {
        }

        enum Species
        {
        }

        protected Organism(int _health)
        {
            alive = true;
            health = _health;
            x = Common.publicRandom.Next(Map.length);
            y = Common.publicRandom.Next(Map.width);
        }

        protected Organism(int _health, int _x, int _y)
        {
            alive = true;
            health = _health;
            x = _x;
            y = _y;
        }

        protected void DestroyOrganism()
        {
            this.alive = false;
            this.health = 0;
        }
    }
}