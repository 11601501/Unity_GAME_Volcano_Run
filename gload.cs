using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gload : MonoBehaviour {
	public GameObject informationobj;
	public GameObject SoundButton;
	public Sprite[] sp;

	public AudioClip buttonsound;
	public static int buttonclick = 1;
	

	// Use this for initialization
	void Start () {
		informationobj.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void showinformation(){
		

		GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<AudioSource> ().mute = !GetComponent<AudioSource> ().mute;
		GameObject.Find("load").GetComponent<AudioSource>().PlayOneShot(buttonsound,5);
		informationobj.gameObject.SetActive (true);
	
	}
	public void hideinformation(){
		GameObject.Find("load").GetComponent<AudioSource>().PlayOneShot(buttonsound,5);
		informationobj.gameObject.SetActive (false);
		GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<AudioSource> ().mute = GetComponent<AudioSource> ().mute;
	}
	public void load(){
		//buttonsound.gameObject.GetComponent<Button> ();
		GameObject.Find("load").GetComponent<AudioSource>().PlayOneShot(buttonsound,5);
		Application.LoadLevel ("2");
	}
	public void stopsound(){
		if (buttonclick == 1) {
			buttonclick = 0;
			SoundButton.gameObject.GetComponent<Button> ().GetComponent<Image> ().sprite = sp [0];
			GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<AudioSource> ().mute = !GetComponent<AudioSource> ().mute;
		} 
		else if (buttonclick == 0) {
			buttonclick = 1;
			SoundButton.gameObject.GetComponent<Button> ().GetComponent<Image> ().sprite = sp [1];
			GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<AudioSource> ().mute = GetComponent<AudioSource> ().mute;

			}
	}
	public void gameover(){
		GameObject.Find("load").GetComponent<AudioSource>().PlayOneShot(buttonsound,5);
		Application.LoadLevel ("1");
	}
}
