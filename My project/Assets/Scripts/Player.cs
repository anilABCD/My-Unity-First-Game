using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 1f;

    [SerializeField]
    private float jumpForce = 11f;

    float movementX;

    private float myMovementX;
    private float myMovementY;

    private Rigidbody2D myBody;

    private Animator anim;

    private SpriteRenderer sr;

    private bool isGrounded = true;

    private string WALK_ANIMATION = "Walk";
    private string GROUND_TAG = "Ground";

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();

        anim.SetBool(WALK_ANIMATION, false);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
       
    }

    private void FixedUpdate()
    {
        PlayerJump();
    }

    void PlayerMoveKeyboard()
    {
        //  myMovementX = Input.GetAxis("Horizontal"); // -1 to 1 slowly from -1 -0.333 -0.22 to  0 to 0.333 0.5 1 

        myMovementX = Input.GetAxisRaw("Horizontal");
    
       if( myMovementX > 0)
        {
            sr.flipX = false;
        }
        else
        if( myMovementX <0)
        {
            sr.flipX = true;
        }
        
        transform.position += new Vector3(myMovementX, 0f, 0f) * Time.deltaTime * moveForce;

       

    }

    void AnimatePlayer()
    {
      
       anim.SetBool(WALK_ANIMATION,myMovementX != 0 ? true: false);
     
    }

    void PlayerJump()
    {


        //if (Input.GetButton("Jump")) // down 
        //{
        //    Debug.Log("Jumpb Pressed Continues");
        //}

        if (Input.GetButtonDown("Jump") && isGrounded ) // down 
        {
            isGrounded = false;

            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

        }


        //if (Input.GetButtonUp("Jump")) // pressed 
        //{
        //    Debug.Log("Jump Button Up");
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            isGrounded = true;
            print("Ground Touched");
        }
    }
}
