using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStateManager : MonoBehaviour {

	public Text InfoText;
	DetectShipColl DetectShipCollScript;
	PlayerCollDetection playerScript;

	public GameObject ProjectileGameObject;
	public GameObject PlayerGameObject;

	// Use this for initialization
	void Start () {
		InfoText.text = "";
		DetectShipCollScript = ProjectileGameObject.GetComponent<DetectShipColl> ();
		playerScript = PlayerGameObject.GetComponent<PlayerCollDetection> ();
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (DetectShipCollScript.GameOver);
		if (DetectShipCollScript.GameOver && playerScript.score > 50) {
			//next level
			Debug.Log ("next level");
		}
		else if (DetectShipCollScript.GameOver && playerScript.score < 50) 
		{
			Debug.Log ("GameOver2");
			InfoText.text ="GAME OVER";
			Invoke ("Restart",2f);
		}
	}

	void Restart()
	{
		Debug.Log ("Restart");
		InfoText.text = "";
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
