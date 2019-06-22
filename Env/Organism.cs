namespace Env
{
    public abstract class Organism
    {
        protected bool alive;
        private int health;
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
        }

        protected void DestroyOrganism()
        {
            this.alive = false;
            this.health = 0;
        }
    }
}