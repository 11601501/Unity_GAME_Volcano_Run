using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
	public GameObject obj1;
	public playerController Players;

	// Use this for initialization
	void Start () {
		Players = GameObject.FindGameObjectWithTag ("Player").GetComponent<playerController> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player") {
			Debug.Log ("Here");
			Players.incscore();
			//Player.SendMessage ("incscore");
			Destroy (obj1);
			//GetComponent<AudioSource>().PlayOneShot(coincollectsound,10);
	};
	}
		
	/*if (col.gameObject.name == "collider") {
			Player.SendMessage ("Lives_Check");
			Destroy (gameObject);
			Start ();
		}*/
               
}
