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
            Character char1 = GetChar1(player1Name);
            string player2Name = Player2();
            Character char2 = GetChar2(player2Name);
            int turn = DiceRoll();
            WhoGoes1st(char1, char2, turn);
           

        }
       static string Player1()
       {
            System.Console.WriteLine("Welcome to the Pirates of the Carribean battle game\nPlayer 1 enter your name");
            string player1Name = Console.ReadLine();
            return player1Name;
            
       }
       static string Player2()
       {
            System.Console.WriteLine("Player 2 enter your name");
            string player2Name = Console.ReadLine();
            return player2Name;
       }
       static Character GetChar1(string player1Name)
       {
           System.Console.WriteLine(player1Name + " choose your character\n1. Davey Jones\n2. Will Turner\n3. Jack Sparrow");
           int choice = int.Parse(Console.ReadLine());
           if(choice == 1)
           {
               return new DaveyJones(){PlayerName = player1Name};
           }
           if(choice == 2)
           {
               return new WillTurner(){PlayerName = player1Name};
           }
           else
           {
               return new JackSparrow(){PlayerName = player1Name};
           }
       }
       static Character GetChar2(string player2Name)
       {
           System.Console.WriteLine(player2Name + " choose your character\n1. Davey Jones\n2. Will Turner\n3. Jack Sparrow");
           int choice = int.Parse(Console.ReadLine());
           if(choice == 1)
           {
               return new DaveyJones(){PlayerName = player2Name};
           }
           if(choice == 2)
           {
               return new WillTurner(){PlayerName = player2Name};
           }
           else
           {
               return new JackSparrow(){PlayerName = player2Name};
           }
       }
       static int DiceRoll()
        {
            Random turn = new Random();
            int turn2 = turn.Next(2)+1;
            return turn2;
        }
        static void WhoGoes1st(Character char1, Character char2, int turn2)
        {
            if(turn2 == 1)
            {
                System.Console.WriteLine(char1.PlayerName + " goes first");
                GamePlay(char1, char2);
            }
            else
            {
                System.Console.WriteLine(char2.PlayerName + " goes first");
                GamePlay(char2, char1);
            }
            
        }
        static void GamePlay(Character char1, Character char2)
            {
               while(char1.Health > 0 && char2.Health > 0)
               {
                    char1.attackBehavior.Attack(char1, char2, char1);
                    System.Console.WriteLine(char2.PlayerName + "'s Stats:\nHealth = " + char2.Health + " Max Power = " + char2.MaxPower + " Attack Strength = " + char2.AttackStrength + " Defense Power = " + char2.DefensePower);
                    System.Console.WriteLine(char1.PlayerName + "'s Stats:\nHealth = " + char1.Health + " Max Power = " + char1.MaxPower + " Attack Strength = " + char1.AttackStrength + " Defense Power = " + char1.DefensePower);
                    WhoWon(char1, char2);
                    char2.attackBehavior.Attack(char2,char1,char2);
                    System.Console.WriteLine(char1.PlayerName + "'s Stats:\nHealth = " + char1.Health + " Max Power = " + char1.MaxPower + " Attack Strength = " + char1.AttackStrength + " Defense Power = " + char1.DefensePower);
                    System.Console.WriteLine(char2.PlayerName + "'s Stats:\nHealth = " + char2.Health + " Max Power = " + char2.MaxPower + " Attack Strength = " + char2.AttackStrength + " Defense Power = " + char2.DefensePower);
                    WhoWon(char1, char2);
               }
              
            }
            static void WhoWon(Character char1, Character char2)
            {
               if(char1.Health <= 0)
               {
                   System.Console.WriteLine(char2.PlayerName + " Won!!");
                   Environment.Exit(0);
               }
               else if(char2.Health <= 0)
               {
                   System.Console.WriteLine(char1.PlayerName + " Won!!");
                   Environment.Exit(0);
               }
            }


       
    }
}

