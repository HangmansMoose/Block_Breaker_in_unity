using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour 
{
	[SerializeField] AudioClip clip;
	
	Level level;
	GameStatus status;
	//OnCollisionEnter2D is an overloaded method from MonoBehviour

	private void Start()
	{
		level = FindObjectOfType<Level>();
		status = FindObjectOfType<GameStatus>();
		//Every time a block is created it should increment this value
		level.CountBreakableBlocks();
	}

	private void DestroyBlock()
	{
		
		AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
		AddToScore();
		Destroy(gameObject);
		level.BlockDestroyed();
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{		
		DestroyBlock();

	}

	private void AddToScore()
	{
		status.IncrementScore();
	}
	
}
