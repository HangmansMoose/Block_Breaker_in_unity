using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

	//As defined in the unity docs for trigger events
	private void OnTriggerEnter2D(Collider2D collision)
	{
		//When collision box is hit trigger game over screen
		SceneManager.LoadScene("Game Over");
	}
}
