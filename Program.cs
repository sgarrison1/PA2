using System;
using PA2.Interfaces;
using System.IO;

namespace PA2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Character myCharacter = new Character();
            // myCharacter.attackBehavior = new Sword();
            // myCharacter.attackBehavior.Attack();
            // myCharacter.attackBehavior = new Distract();
            // myCharacter.attackBehavior.Attack();
            // myCharacter.attackBehavior= new CannonFire();
            // myCharacter.attackBehavior.Attack(); 
            // Menu();
            // int turn = WhoGoes1st();
            // GamePlay(turn);
            Character player1 = new DaveyJones(){CharacterName = "Davey Jones"};
            Console.WriteLine("Player " + player1.PlayerName + "'s character "+ player1.CharacterName + "'s strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health + " there max power is " + player1.MaxPower);

            Character player2 = new JackSparrow(){CharacterName = "Jack Sparrow"};
            Console.WriteLine("Player " + player2.PlayerName + "'s character "+ player2.CharacterName + "'s strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health + " there max power is " + player2.MaxPower);
            
            // player1.attackBehavior.Attack(player1.AttackStrength, player2.DefensePower, player2.Health);
            player1.attackBehavior.Attack(player1, player2);

            System.Console.WriteLine("The attacker attacked with " + player1.AttackStrength + " the defender now has" + player2.Health+ "health");
            //player2.attackBehavior.Attack(player2.AttackStrength, player1.DefensePower, player1.Health);
            System.Console.WriteLine("The attacker attacked with " + player2.AttackStrength + " the defender now has" + player1.Health+ "health");
            //how do i keep the stats updates?




        }

       static void Menu()
       {
            System.Console.WriteLine("Welcome to the Pirates of the Carribean battle game\nPlayer 1 enter your name");
            string player1Name = Console.ReadLine();
            Console.WriteLine("choose your charecter:\n1. Davey Jones\n2. Jack Sparrow\n3. Will Turner");
            int player1Character = int.Parse(Console.ReadLine());
            Player1Stats(player1Character, player1Name);
            System.Console.WriteLine("PLayer 2 enter your name");
            string player2Name = Console.ReadLine();
            Console.WriteLine("choose your character:\n1. Davey Jones\n2. Jack Sparrow\n3. Will Turner");
            int player2Character = int.Parse(Console.ReadLine());
            Player2Stats(player2Character, player2Name);
       }
       static void Player1Stats(int player1Character, string player1Name)
       {
           if(player1Character == 1)
           {
                Character player1 = new DaveyJones(){PlayerName = player1Name, CharacterName = "Davey Jones"};
                Console.WriteLine("Player " + player1.PlayerName + "'s character "+ player1.CharacterName + "'s strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health + " there max power is " + player1.MaxPower);
           }
           if(player1Character == 2)
           {
                Character player1 = new JackSparrow(){PlayerName = player1Name,CharacterName = "Jack Sparrow"};
                Console.WriteLine("Player " + player1.PlayerName + "'s character "+ player1.CharacterName + "'s strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health + " there max power is " + player1.MaxPower);
           }
           if(player1Character == 3)
           {
                Character player1 = new WillTurner(){PlayerName = player1Name,CharacterName = "Will turner"};
                Console.WriteLine("Player " + player1.PlayerName + "'s character "+ player1.CharacterName + "'s strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health + " there max power is " + player1.MaxPower);
           }
       }
       static void Player2Stats(int player2Character, string player2Name)
       {
           if(player2Character == 1)
           {
                Character player2 = new DaveyJones(){PlayerName = player2Name, CharacterName = "Davey Jones"};
                Console.WriteLine("Player " + player2.PlayerName + "'s character "+ player2.CharacterName + "'s strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health + " there max power is " + player2.MaxPower);
           }
           if(player2Character == 2)
           {
                Character player2 = new JackSparrow(){PlayerName = player2Name,CharacterName = "Jack Sparrow"};
                Console.WriteLine("Player " + player2.PlayerName + "'s character "+ player2.CharacterName + "'s strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health + " there max power is " + player2.MaxPower);
           }
           if(player2Character == 3)
           {
                Character player2 = new WillTurner(){PlayerName = player2Name,CharacterName = "Will turner"};
                Console.WriteLine("Player " + player2.PlayerName + "'s character "+ player2.CharacterName + "'s strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health + " there max power is " + player2.MaxPower);
           }

       }

       static int WhoGoes1st()
        {
            Random turn = new Random();
            int turn2 = turn.Next(2)+1;
            return turn2;
        }
        static void GamePlay(int turn2)
        {
            if(turn2 == 1)
            {
                System.Console.WriteLine("player 1 goes first"); //same game play with different order 
            }
            else if(turn2 ==2)
            {
                System.Console.WriteLine("Player 2 goes first");

            }
        }
       
    }
}
//max power and other power calculations