using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blademovement : MonoBehaviour
{
    public float speed = 5f;    //t‰ll‰ m‰‰ritet‰‰n ter‰n nopeus

    public float upMax = 5;		    //n‰ill‰ m‰‰ritet‰‰n kohdat joissa ter‰ vaihtaa suuntaa
	public float downMax = -5;		//

    private Transform transform;

    public bool goUp = true;
    public bool moving = true;


	private void Start()
	{
		transform = this.GetComponent<Transform>();
	}
   

	void Update()
    {
        if (moving)
        {
            if (transform.position.y < downMax)        //ter‰n osuessa alueensa alareunaan vaihtuu suunta ylˆsp‰in
            {
                goUp = true;
            }
            else if (transform.position.y > upMax)       //ter‰n osuessa alueensa yl‰reunaan vaihtuu suunta alasp‰in
            {
                goUp = false;
            }

            if (goUp)
            {
                transform.Translate(0f, speed * Time.deltaTime, 0f);    //liikuttaa ter‰‰ ylˆsp‰in
            }
            else
            {
                transform.Translate(0f, -speed * Time.deltaTime, 0f);   //liikuttaa ter‰‰ alasp‰in
            }
        }
    }
}


