using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {

	public float MaxSpeed = 3.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Move left and right
		Vector3 CurrentPos = transform.position;
		CurrentPos.x = Input.GetAxis ("Horizontal") * MaxSpeed * Time.deltaTime;

		transform.position = CurrentPos;
	}
}
