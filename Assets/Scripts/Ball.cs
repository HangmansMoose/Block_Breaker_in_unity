using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour 
{

	[SerializeField] Paddle paddle;
	[SerializeField] float xInitVelocity = 2f;
	[SerializeField] float yInitVelocity = 15f;
	[SerializeField] AudioClip[] ballSounds;
	
	Vector2 paddleBallDelta;
	bool hasStarted = false;
	
	// Use this for initialization
	void Start () 
	{
		paddleBallDelta = transform.position - paddle.transform.position;	
		
	}
	
	// Update is called once per frame
	void Update () 
	{	
		if(!hasStarted)
		{
			BallLockStart();
			ClickLaunch();
			
		}
					
	}

	private void BallLockStart()
	{
		//Get the current position of the paddle
		Vector2 paddlePosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
		transform.position = paddlePosition + paddleBallDelta;
	}

	private void ClickLaunch()
	{
		if(Input.GetMouseButtonDown(0))
		{
			//Give the ball a velocity on click
			GetComponent<Rigidbody2D>().velocity = new Vector2(xInitVelocity, yInitVelocity);
			hasStarted = true;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(hasStarted)
		{
			//Randomly select one of the sounds to play each collision
			AudioClip clip = ballSounds[Random.Range(0, ballSounds.Length)];
			GetComponent<AudioSource>().PlayOneShot(clip);
		}
	}
}
