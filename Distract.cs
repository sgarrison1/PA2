namespace PA2.Interfaces
{
    public class Distract:IAttack
    {
        public void Attack(Character attacker, Character defender, Character playerName) //pass in attacker and defender 
        {
            System.Console.WriteLine(playerName.PlayerName + " attacked with Distract");
            if (defender.ToString() == "PA2.Interfaces.WillTurner")
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