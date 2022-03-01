using System.IO;
using System;
namespace PA2.Interfaces
{
    public class Character
    {
        public string PlayerName{get;set;}
        public string CharacterName{get;set;}
        public int MaxPower{get;set;}
        public double Health{get;set;}
        public int AttackStrength{get;set;}
        public int  DefensePower{get;set;}

        public IAttack attackBehavior{get;set;}
        public Character()
        {
            attackBehavior = new Distract();
            MaxPower = GetMaxPower();
            Health = GetHealth();
            AttackStrength = GetAttackStrength();
            DefensePower = GetDefensePower();
            
        }
        

        public int GetMaxPower()
        {
            Random maxPower = new Random();
            MaxPower = maxPower.Next(99)+1;
            return MaxPower;
        }
        public double GetHealth()
        {
            return Health = 100;
        }
        public int GetAttackStrength()
        {
            Random attackStrength = new Random();
            AttackStrength = attackStrength.Next(MaxPower);
            return AttackStrength;
        }
        public int GetDefensePower()
        {
            Random defensePower = new Random();
            DefensePower = defensePower.Next(MaxPower)+1;
            return DefensePower;
        }
        


        

    }
}