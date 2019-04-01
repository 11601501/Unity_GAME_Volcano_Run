using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroy2 : MonoBehaviour {
	public GameObject life1;
	public GameObject life2;
	public GameObject life3;
	static int c = 3;

	public playerController Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player").GetComponent<playerController> ();

	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.tag == "fire") {
			//Player.SendMessage ("Lives_check");
			Destroy (gameObject);

			//Application.LoadLevel (Application.loadedLevel);
			switch (c) {
			case 1:
				//Destroy (life1);
				Application.LoadLevel ("5");
				c = 3;
				break;
			case 2:
				//Destroy (life2);
				Application.LoadLevel ("4");
				c--;
				break;
			case 3:
				//Destroy (life3);
				Application.LoadLevel ("3");
				c--;
				break;
			default:
				
				Application.LoadLevel ("2");

				break;
			}
			


		}




	}
}
