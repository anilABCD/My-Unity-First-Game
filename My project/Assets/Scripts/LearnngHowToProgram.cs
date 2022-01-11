using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnngHowToProgram : MonoBehaviour
{

    // main Variables for class 
    double mana = 15.5;

    float speed = 1.4f;
 
    int health = 100;

    string playerName = "Warrior";

    bool isDead = true;


    // start ... 
    private void Start()
    {

        float a = 20;
        float b = 7;

        float c = a / b;

        print(a + " + " + b + " = " + c);

        print("this is : print");

        Debug.Log("this is : Debug.Log");

        StartCoroutine(ExecuteSomething(2));
        
    }


    IEnumerator ExecuteSomething(float time)
    {
        yield return new WaitForSeconds(time);

        Debug.Log("Something is exected");
    }

    // update ... 
    private void Update()
    {
        
    }

}

