using System.Numerics;
using System;
using PA2.Interfaces;
using System.IO;

namespace PA2
{
    class Program
    {
        static void Main(string[] args)
        {  
            string player1Name = Player1();
            string player2Name = Player2();
            int turn = WhoGoes1st();
            CharacterChoices(turn, player1Name, player2Name);

        }

       static string Player1()
       {
            System.Console.WriteLine("Welcome to the Pirates of the Carribean battle game\nPlayer 1 enter your name");
            string player1Name = Console.ReadLine();
            return player1Name;
            
       }
       static string Player2()
       {
            System.Console.WriteLine("PLayer 2 enter your name");
            string player2Name = Console.ReadLine();
            return player2Name;
       }

       static int WhoGoes1st()
        {
            Random turn = new Random();
            int turn2 = turn.Next(2)+1;
            return turn2;
        }
        static void CharacterChoices(int turn2, string player1Name, string player2Name)
        {
            if(turn2 == 1)
            {
                System.Console.WriteLine("player 1 goes first"); 
                System.Console.WriteLine(player1Name + " Select your character\n1. Davey Jone\n2. Will Turner\n3. Jack Sparrow");
                int player1Character = int.Parse(Console.ReadLine());
                System.Console.WriteLine(player2Name +  " Select your character\n1. Davey Jone\n2. Will Turner\n3. Jack Sparrow");
                int player2Character = int.Parse(Console.ReadLine());
                if(player1Character == 1 && player2Character == 1)
                {
                    Character player1 = new DaveyJones(){PlayerName = player1Name};
                    Console.WriteLine("Player " + player1.PlayerName + "'s max power is " + player1.MaxPower + " their strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health);
                    Character player2 = new DaveyJones(){PlayerName = player2Name};
                    Console.WriteLine("Player " + player2.PlayerName + "'s max power is " + player2.MaxPower + " their strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health);
                    GamePlay(player1,player2);
                }
                else if(player1Character == 1 && player2Character == 2)
                {
                    Character player1 = new DaveyJones(){PlayerName = player1Name};
                    Console.WriteLine("Player " + player1.PlayerName + "'s max power is " + player1.MaxPower + " their strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health);
                    Character player2 = new WillTurner(){PlayerName = player2Name};
                    Console.WriteLine("Player " + player2.PlayerName + "'s max power is " + player2.MaxPower + " their strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health);
                    GamePlay(player1,player2);
                }
                else if(player1Character == 1 && player2Character == 3)
                {
                    Character player1 = new DaveyJones(){PlayerName =player1Name};
                    System.Console.WriteLine("Player " + player1.PlayerName + "'s max power is " + player1.MaxPower + " their strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health);
                    Character player2 = new JackSparrow(){PlayerName = player2Name};
                    Console.WriteLine("Player " + player2.PlayerName + "'s max power is " + player2.MaxPower + " their strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health);
                    GamePlay(player1,player2);
                }
                else if(player2Character == 2 && player1Character == 1)
                {
                    Character player1 = new DaveyJones(){PlayerName = player1Name};
                    Console.WriteLine("Player " + player1.PlayerName + "'s max power is " + player1.MaxPower + " their strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health);
                    Character player2 = new WillTurner(){PlayerName = player2Name};
                     Console.WriteLine("Player " + player2.PlayerName + "'s max power is " + player2.MaxPower + " their strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health);
                     GamePlay(player1,player2);
                    
                }
                else if(player2Character == 2)
                {
                    Character player2 = new WillTurner(){PlayerName = player2Name};
                    Console.WriteLine("Player " + player2.PlayerName + "'s max power is " + player2.MaxPower + " their strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health);
                }
                else if(player2Character == 3)
                {
                    Character player2 = new JackSparrow(){PlayerName = player2Name};
                    Console.WriteLine("Player " + player2.PlayerName + "'s max power is " + player2.MaxPower + " their strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health);
                }
                
            }
            else if(turn2 ==2)
            {
                System.Console.WriteLine("Player 2 goes first");
                System.Console.WriteLine(player2Name + " Select your character\n1. Davey Jone\n2. Will Turner\n3. Jack Sparrow");
                int player2Character = int.Parse(Console.ReadLine());
                System.Console.WriteLine(player1Name + " Select your character\n1. Davey Jone\n2. Will Turner\n3. Jack Sparrow");
                int player1Character = int.Parse(Console.ReadLine());
                if(player1Character == 1 && player2Character == 1)
                {
                    Character player1 = new DaveyJones(){PlayerName = player1Name};
                    Console.WriteLine("Player " + player1.PlayerName + "'s max power is " + player1.MaxPower + " their strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health);
                    Character player2 = new DaveyJones(){PlayerName = player2Name};
                    Console.WriteLine("Player " + player2.PlayerName + "'s max power is " + player2.MaxPower + " their strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health);
                    GamePlay(player2,player1);
                }
                else if(player2Character == 2)
                {
                    Character player2 = new WillTurner(){PlayerName = player2Name};
                    Console.WriteLine("Player " + player2.PlayerName + "'s max power is " + player2.MaxPower + " their strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health);
                }
                else if(player2Character == 3)
                {
                    Character player2 = new JackSparrow(){PlayerName = player2Name};
                    Console.WriteLine("Player " + player2.PlayerName + "'s max power is " + player2.MaxPower + " their strength is " + player2.AttackStrength + " there defense power is " + player2.DefensePower+ " there health is "+ player2.Health);
                }

                
                else if(player1Character == 1)
                {
                    Character player1 = new DaveyJones(){PlayerName = player1Name};
                    Console.WriteLine("Player " + player1.PlayerName + "'s max power is " + player1.MaxPower + " their strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health);
                }
                else if(player1Character == 2)
                {
                    Character player1 = new WillTurner(){PlayerName = player1Name};
                    Console.WriteLine("Player " + player1.PlayerName + "'s max power is " + player1.MaxPower + " their strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health);
                }
                else if(player1Character == 3)
                {
                    Character player1 = new JackSparrow(){PlayerName = player1Name};
                    Console.WriteLine("Player " + player1.PlayerName + "'s max power is " + player1.MaxPower + " their strength is " + player1.AttackStrength + " there defense power is " + player1.DefensePower+ " there health is "+ player1.Health);
                }

            }
            

        }
        static void GamePlay(Character playerA, Character playerB)
            {
               while(playerA.Health > 0 && playerB.Health > 0)
               {
                    playerA.attackBehavior.Attack(playerA, playerB, playerA);
                    System.Console.WriteLine("The attacker attacked with " + playerA.AttackStrength + " the defender now has " + playerB.Health + " health");
                    System.Console.WriteLine("PLAYER STATS:\nPlayer " + playerA.PlayerName + "'s max power is " + playerA.MaxPower + " their strength is " + playerA.AttackStrength + " there defense power is " + playerA.DefensePower+ " there health is "+ playerA.Health + "\nPlayer " + playerB.PlayerName + "'s max power is " + playerB.MaxPower + " their strength is " + playerB.AttackStrength + " there defense power is " + playerB.DefensePower+ " there health is "+ playerB.Health);
                    playerB.attackBehavior.Attack(playerB,playerA,playerB);
                    System.Console.WriteLine("The attacker attacked with " + playerB.AttackStrength + " the defender now has " + playerA.Health + " health");
                    System.Console.WriteLine("PLAYER STATS:\nPlayer " + playerA.PlayerName + "'s max power is " + playerA.MaxPower + " their strength is " + playerA.AttackStrength + " there defense power is " + playerA.DefensePower+ " there health is "+ playerA.Health + "\nPlayer " + playerB.PlayerName + "'s max power is " + playerB.MaxPower + " their strength is " + playerB.AttackStrength + " there defense power is " + playerB.DefensePower+ " there health is "+ playerB.Health);

               }
               if(playerA.Health <= 0)
               {
                   System.Console.WriteLine(playerB.PlayerName + " Won!!");
               }
               else if(playerB.Health <= 0)
               {
                   System.Console.WriteLine(playerA.PlayerName + " Won!!");
               }
            }
       
    }
}

