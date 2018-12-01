using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour 
{

	[SerializeField] float widthInUnityUnits = 16f;
	
	//This is to just explicetly define the value of y instead of using the transform
	[SerializeField] float paddleConstantY = 0.25f;

	[SerializeField] float clampLow = 1.0f;
	[SerializeField] float clampHigh = 15.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		//find the x positon of the mouse independant of resolution
		float mouseX = (Input.mousePosition.x / Screen.width * widthInUnityUnits);
		//Note that this needs to be clamped at 1 and 15 because it has a width of 2
		mouseX = (Mathf.Clamp(mouseX, clampLow, clampHigh));
		//create a vector to pass paddle position
		Vector2 paddlePostion = new Vector2(mouseX, paddleConstantY);

		transform.position = paddlePostion;

	}
}
