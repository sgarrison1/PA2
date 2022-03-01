namespace PA2.Interfaces
{
    public class DaveyJones: Character
    {
        public IAttack attackbehavior{get;set;}
        public DaveyJones()
        {
            attackBehavior = new CannonFire();
        }

    }
}