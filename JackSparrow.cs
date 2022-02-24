namespace PA2.Interfaces
{
    public class JackSparrow : Character
    {
        public IAttack attackbehavior{get;set;}
        public JackSparrow()
        {
            attackBehavior = new Distract();
        }
    }
}