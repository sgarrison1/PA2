namespace PA2.Interfaces
{
    public class WillTurner : Character
    {
        public IAttack attackbehavior{get;set;}
        public WillTurner()
        {
            attackBehavior = new Sword();
        }
    }
}