using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   [SerializeField] private LayerMask platformLayerMask;

    public float walkSpeed = 22f;

    public float jumpVelocity = 0f;

    private bool isjumping = false;
    private bool ismoving = false;
    private bool goingLeft = false;
    private bool goingRight = false;


    public Animator animator;

    private Rigidbody2D rigidbody1;
    private BoxCollider2D boxcollider;


	private void Start()
	{
        this.GetComponent<Rigidbody2D>().freezeRotation = true;
        rigidbody1 = this.GetComponent<Rigidbody2D>();
        boxcollider = this.GetComponent<BoxCollider2D>();
    }



	void Update()
    {

      

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) //liikkuu/k‰‰ntyy vasemmalle A n‰pp‰int‰ painaessa
        {
            goingLeft = true;
            this.GetComponent<Transform>().Translate(walkSpeed * Time.deltaTime, 0f, 0f);
            if (this.GetComponent<Transform>().eulerAngles.y < 180)
            {                                                                                                           
                this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
            }
		}
		else
		{
            goingLeft = false;
        }
      
       

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))    //liikkuu/k‰‰ntyy oikealle D n‰pp‰int‰ painaessa
        {
            goingRight = true;
            this.GetComponent<Transform>().Translate(walkSpeed * Time.deltaTime, 0f, 0f);
            if (this.GetComponent<Transform>().eulerAngles.y >= 180) 
            {                                                                                                           
                this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
            }
        }
		else
		{
            goingRight = false;
        }



		if (isGrounded() && Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && isGrounded())
		{
            rigidbody1.velocity = Vector2.up * this.jumpVelocity;
           
            isjumping = true;
		}
		else
		{
            isjumping = false;
		}

     



        if(goingLeft == true || goingRight == true)     //tarkistaa liikkuuko hahmo
		{
            ismoving = true;
		}
		else
		{
            ismoving = false;
		}





		if (ismoving)                               //hahmon liikkuessa n‰ytet‰‰n k‰velemis animaatio
		{
           animator.SetBool("moving", true);
		}
		else
		{
            animator.SetBool("moving", false);
      }

	
        
    } 
    
    private bool isGrounded()
	{
       RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxcollider.bounds.center, boxcollider.bounds.size, 0f, Vector2.down, 0.1f, platformLayerMask);
        
       return raycastHit2D.collider != null;
	}
    

}
