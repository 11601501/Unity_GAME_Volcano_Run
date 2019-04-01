using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour {

	//public Transform target;
	public GameObject target;


	// Use this for initialization
	void Start () {

		target = GameObject.Find ("Player");

	}

	// Update is called once per frame
	void Update () {
		//target = GameObject.Find ("target").transform;
		//transform.LookAt (target);

		Vector3 targetpos = new Vector3 (target.transform.position.x,
			                    transform.position.y,   	                    
			                    target.transform.position.z);
		if (target.transform.position.x < 2.0f) 
		{
			transform.LookAt (targetpos);
		}
	}

}
