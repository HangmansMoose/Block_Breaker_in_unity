using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour 
{
	[SerializeField] AudioClip clip;
	
	//OnCollisionEnter2D is an overloaded method from MonoBehviour
	private void OnCollisionEnter2D(Collision2D collision)
	{
		AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
		Destroy(gameObject);
	}
	
}
