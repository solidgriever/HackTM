using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollDetection : MonoBehaviour {

	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Enemy") 
		{
			score += 5;		
		} 

	}		
}
