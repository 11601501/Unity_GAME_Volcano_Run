using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour 
{
	//playerController Player;
	//public Sprite[] sp;
	public Vector2 pos;
	private Animator anim;
	Rigidbody2D PlayerRigidbody;
	public AudioClip coincollectsound;
	public bool grounded;
	public Transform groundCheck;

	//public GameObject[] array;
	public Text myscore;
	static int score =0;

	public Text highscore;
	static int hs;
	public Text lives;
	int lives_cal = 4;
	static int _lives;


	// Use this for initialization
	void Start () {
		//Invoke ("CreateObject", 1f);
		//Player = GameObject.FindGameObjectWithTag ("Player").GetComponent<playerController> ();
		PlayerRigidbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		
	}

	/*void CreateObject()
	{
		Instantiate(array[Random.Range(0,1)],transform.position,transform.rotation);
	}*/
	
	// Update is called once per frame
	void Update ()
	{
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("ground"));

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			if (transform.eulerAngles.y != 0)
				transform.eulerAngles = new Vector3 (0, 0, 0);
			anim.Play ("walk");
			pos = transform.position;
			pos.x = pos.x + 0.1f;
			transform.position = pos;

		};

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			anim.Play ("idle");
		};

		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (transform.eulerAngles.y != 180)
				transform.eulerAngles = new Vector3 (0, 180, 0);
			anim.Play ("walk"); // PlayerRigidbody.velocity = new Vector2(-moveSpeed, PlayerRigidbody.velocity.y);
			pos = transform.position;
			pos.x = pos.x - 0.1f;
			transform.position = pos;  
		};

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			anim.Play ("idle");
		};

		if (Input.GetKey (KeyCode.Space)) {
			anim.Play ("Jump");
			pos = transform.position;
			pos.y = pos.y + 0.4f;
			transform.position = pos;
		};
 	}


	public void HighScore(int score)
	{

		highscore.text = score.ToString ();
	}

	public void incscore()
	{
		score = score + 1;
		myscore.text = score.ToString ();

		/*if (hs < score) {
			hs = hs + 1;
			HighScore (hs);
		}*/
	}

	public void Lives_check()
	{

		//Debug.Log ("working");

		lives_cal = lives_cal - 1;

		if (lives_cal > 0) 
		{
			lives.text = lives_cal.ToString ();

		}
		if (lives_cal == 0) 
		{
			lives.text = lives_cal.ToString ();
		}

	}

}
