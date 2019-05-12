using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Controller : MonoBehaviour 
{


	public AudioSource mainTheme;

	public AudioSource marble;

	public AudioSource jump;

	public AudioSource spike;

	public AudioSource smallClap;

	public AudioSource win;






	// Use this for initialization
	void Start () 
	{
		mainTheme = GetComponent<AudioSource>();
		marble = GameObject.Find("Marble").GetComponent<AudioSource>();
		jump = GameObject.Find("Jump").GetComponent<AudioSource>();
		spike = GameObject.Find("SpikeSound").GetComponent<AudioSource>();
		smallClap = GameObject.Find("Clap").GetComponent<AudioSource>();
		win = GameObject.Find("Victory").GetComponent<AudioSource>();



	
		mainTheme.Play();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
