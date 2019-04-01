using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camerafollow : MonoBehaviour {

	public GameObject Player;
	Vector3 Offset;

	//public Transform target;

	// Use this for initialization
	void Start () {
		Offset = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Player.transform.position + Offset;
	
		//transform.LookAt(target); 

	}
}
