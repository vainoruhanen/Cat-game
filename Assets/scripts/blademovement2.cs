using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blademovement2 : MonoBehaviour
{

    public float leftMax = 8f;      //n‰ill‰ m‰‰ritet‰‰n kohdat joissa ter‰ vaihtaa suuntaa
    public float rightMax = 0f;     //

    private Transform transform;

    public float speed = 5f;    //t‰ll‰ m‰‰ritet‰‰n ter‰n nopeus

    public bool goRight = true;

    void Start()
    {
        transform = this.GetComponent<Transform>();
    }

    void Update()
    {
        if (transform.position.x < leftMax)   //vaihtaa ter‰n suuntaa alueensa rajaan osuttaessa     
        {
            goRight = true;
        }
		else if( transform.position.x > rightMax)   //vaihtaa ter‰n suuntaa alueensa rajaan osuttaessa  
        {
            goRight = false;
        }
            

		if (goRight)
		{
            transform.Translate(speed * Time.deltaTime, 0f, 0f);    //liikuttaa ter‰‰ oikealle
        }
		else
		{
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);    //liikuttaa ter‰‰ vasemalle
        }
      
    }
}


