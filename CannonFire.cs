namespace PA2.Interfaces
{
    public class CannonFire: IAttack
    {
        public void Attack(Character attacker, Character defender)
        {
            System.Console.WriteLine("cannon");
            System.Console.WriteLine(defender.ToString());
            if (defender.ToString() == "PA2.Interfaces.JackSparrow")
            {
                double damage = (attacker.AttackStrength - defender.DefensePower)*(1.2);
                 defender.Health -= damage;
            }
            else
            {
                double damage = (attacker.AttackStrength - defender.DefensePower)*(1);
                 defender.Health -= damage;
            }
        }

           
    }
}