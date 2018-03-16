using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerScript : MonoBehaviour {
	private AudioSource audioSource;
	public AudioClip soundBlow;
	public AudioClip soundHit;

	private GameController gameController;

	// Use this for initialization
	void Start () {
		gameController = GameObject.Find ("GameController").GetComponent<GameController> ();

		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.PlayOneShot (soundBlow);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			gameController.AddScore (10);
			audioSource.PlayOneShot (soundHit);
			Destroy (other.gameObject);
		}
	}

}
