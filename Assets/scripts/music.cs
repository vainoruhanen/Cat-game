using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
	private static music musiikkiobjekti;

	void Awake()
	{
		DontDestroyOnLoad(this);

		if(musiikkiobjekti == null)
		{
			musiikkiobjekti = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}


}
