using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour 
{
	//This entire script is purely to keep track of the win state.
	[SerializeField] int breakableBlocks;

	SceneLoader loader;

	private void Start()
	{
		loader = FindObjectOfType<SceneLoader>();
	}

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			loader.LoadStartScene();
		}
	}

	public void CountBreakableBlocks()
	{
		breakableBlocks++;
	}

	public void BlockDestroyed()
	{
		breakableBlocks--;
		
		if(breakableBlocks <= 0)
		{	
			loader.LoadNextScene();
		}

	}


	

}
