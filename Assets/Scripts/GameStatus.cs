using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour 
{
	[SerializeField] int score = 0;
	[SerializeField] int blockPointValue = 500;
	[SerializeField] TextMeshProUGUI scoreText;

	private void Awake()
	{
		int gameStatusCount = FindObjectsOfType<GameStatus>().Length;

		if(gameStatusCount > 1)
		{
			//maintain only one gamestatus to preserve score
			Destroy(gameObject);
		}
	}

	void Start()
	{
		//init the score to 0
		scoreText.text = score.ToString();
	}


	public void IncrementScore()
	{
		score += blockPointValue;
		scoreText.text = score.ToString();
	}
}
