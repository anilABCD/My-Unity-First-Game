using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Player
{
    public Warrior(int health, int power, string name) : base(health, power, name)
    {
       
        Health = health;
        Power = power;
        Name = name;
    }

    public override void Attack()
    {
        print("Warrior is attacking with Axe");
    }
}
