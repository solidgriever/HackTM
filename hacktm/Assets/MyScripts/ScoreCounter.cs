using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCounter : MonoBehaviour {

	public GameObject PlayerGameObject;
	public Text ScoreText;
	PlayerCollDetection playerScript;

	// Use this for initialization
	void Start () {
		
		playerScript = PlayerGameObject.GetComponent<PlayerCollDetection> ();

	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = "Score: " + playerScript.score.ToString();
	}
}
