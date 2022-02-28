namespace PA2.Interfaces
{
    public class Sword :IAttack
    {
        public void Attack(Character attacker, Character defender, Character playerName)
        {
            System.Console.WriteLine(playerName.PlayerName + " attacked with sword");
            if (defender.ToString() == "PA2.Interfaces.DaveyJones")
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