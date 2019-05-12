using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player_Controller : MonoBehaviour 
{

	public float jumpHeight;

	bool canJump = false;
	bool youWin = false;

	//Other Components
	Text victoryText;

	GameObject myCam;

	Music_Controller mc;


	//My Componets
	Rigidbody body;
	SphereCollider sc;

	// Use this for initialization
	void Start () 
	{
		body = GetComponent<Rigidbody>();
		sc = GetComponent<SphereCollider>();
		//victoryText = GameObject.Find("Win").GetComponent<Text>();
		myCam = GameObject.Find("Main Camera");
		mc = GameObject.Find("MainTheme").GetComponent<Music_Controller>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	transform.Translate(0, 0, -Input.acceleration.x);
	
			//victoryText.transform.position = myCam.transform.position +  new Vector3(0f, -50f, 10f);



		//transform.Translate(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);
		 //transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		//ballyPos = new Vector3(0f, jumpHeight, 0f);
		//ballyPos = transform.position.y;
		if(Input.GetMouseButtonDown(0))
		{

			if(canJump) 
			{
				mc.jump.Play();
				mc.marble.Stop();
				print("You jumped");
				body.AddForce(Vector3.up*jumpHeight, ForceMode.Impulse);
				canJump = false;
			}

        //transform.Translate( );	

			//print("the ball y pos is " + ballyPos)	;

			//ballyPos += jumpHeight;
		}	
	}

	
	void OnCollisionEnter(Collision other)
	{
		mc.jump.Stop();
		mc.marble.Play();
		print("You have collided");
		canJump = true;

		if(other.gameObject.tag == "Win Area")
		{
			print("You win!!!");
		}

		if(other.gameObject.tag == "Spike")
		{
			mc.spike.Play();
			print("You hit a spike");
		}

		if(other.gameObject.tag == "Ramp")
		{
			mc.smallClap.Play();
			print("You made air!!");
		}

		if(other.gameObject.tag == "Win Area")
		{
			mc.mainTheme.Stop();
			mc.win.Play();
			print("Congrats you win!!");
		}
	}

	 void OnCollisionExit(Collision other) 
	 {
				mc.marble.Stop();
	}
}
