using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoLearning : MonoBehaviour
{
    Player warrior;
    Player archer;


    private Rigidbody2D myBody;
    private BoxCollider2D myBoxCollider2D;
    private AudioSource myAudiosource;
    private Animator anim;
   
    private Transform myTransform;

    
    public TwoLearning()
    {
        //myBody = GetComponent<Rigidbody2D>();

    

      
    }


    // 1 st function that is called ... 
    private void Awake()
    {
        
    }

    // 2nd function called before start ...
    private void OnEnable()
    {
        
    }

    // 3rd function called ... 
    private void Start()
    {
       
        myTransform = transform;

        myTransform.position = new Vector3(1, 1, 1);

        warrior = new Warrior(100, 100, "Warrior");
        archer = new Player(100, 100, "Archer");

        warrior.Attack();

        archer.Attack();
        
    }

    private void Update()
    {
        
    }

}
