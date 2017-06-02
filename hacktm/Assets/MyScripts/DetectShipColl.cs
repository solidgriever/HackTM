using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectShipColl : MonoBehaviour {

	public ParticleSystem ps;
	public bool GameOver;
	// Use this for initialization
	void Start () {
		
		GameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

	private GameObject m_gameObject = null;
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Planet") 
		{
			
			GameOver = true;
            //SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
            SceneManager.LoadScene("Load3");

		} 
		else if (coll.gameObject.tag == "Player") 
		{
			ps.Play ();
			m_gameObject = coll.gameObject;
			Invoke ("Destroy", 0.3f);

		}
	}

	void Destroy()
	{
		Destroy (gameObject);
	}
}
