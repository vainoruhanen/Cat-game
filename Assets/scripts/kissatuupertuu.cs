using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class kissatuupertuu : MonoBehaviour
{

	private float laskuri1 = 0f;
	private bool isDead = false;

	private void OnTriggerEnter2D(Collider2D collision) //osuessa triggeriksi merkittyyn esteeseen
	{
		if(collision.gameObject.tag == "obstacle")  //kissa "kuolee"
		{
			GameObject.Find("musiikki").GetComponents<AudioSource>()[1].Play();

			this.GetComponent<movement>().enabled = false;	//kun kissa "kuolee" estet��n liikkuminen

			this.GetComponent<Animator>().Play("kissakuolee");		//toistaa kissan kuolemis animaation
			isDead = true;

			
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)	//osuessa kiinte��n esteeseen
	{
		if(collision.gameObject.tag == "obstacle")
		{
			GameObject.Find("musiikki").GetComponents<AudioSource>()[1].Play();
			this.GetComponent<movement>().enabled = false;

			this.GetComponent<Animator>().Play("kissakuolee");
			isDead = true;

		}
	}



	private void Update()
	{
		if (isDead)
		{
			laskuri1 += Time.deltaTime;
		}
		else
		{
			laskuri1 = 0;
		}
	

		if(laskuri1 > 2)	//hahmon kuollessa/t�rm�tess� esteeseen laskee tietyn ajan ennen kun taso alkaa alusta 
		{
			respawn();
		}
	}

	private void respawn()		//taso alkaa alusta
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		isDead = false;
	}

}
