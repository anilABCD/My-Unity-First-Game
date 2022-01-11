using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

   private int _health;
   private int _power;
   private string _name;

   public int Health
    {
        get
        {
            return _health;
        }

        set
        {
            _health = value;
        }
    }

    public int Power
    {
        get
        {
            return _power;
        }

        set
        {
            _power = value;
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }

    public Player(int health, int power, string name)
    {
        this._health = health;
        this._power = power;
        this._name = name;
    }

    public virtual void Attack()
    {
        print("Player is attacking with the fire");
    }
     
    public void Info()
    {
        Debug.Log("Health is: " + Health);
        Debug.Log("Power is: " + Power);
        Debug.Log("Name is: " + Name);
    }
}
