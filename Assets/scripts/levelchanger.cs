using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelchanger : MonoBehaviour
{
    private Transform transform;
    public float levelChangePoint = 9.3f;

    void Start()
    {
        transform = this.GetComponent<Transform>();
    }
    

    void Update()
    {
        if(transform.position.x >= levelChangePoint)
		{
            nextLevel();
		}
    }


   void nextLevel()
	{
        Debug.Log("next level");
		if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Taso1Scene1"))
		{
            SceneManager.LoadScene("Taso1Scene2");
		}
        
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Taso1Scene2"))
		{
            SceneManager.LoadScene("Taso1Scene3");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Taso1Scene3"))
        {
            SceneManager.LoadScene("Taso1Scene4");
        }

    }
}
