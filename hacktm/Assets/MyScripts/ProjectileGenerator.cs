using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileGenerator : MonoBehaviour {

	public GameObject projectile;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateProjectile", 1f, 1.5f);
	}

	void CreateProjectile () 
	{
		
		Vector3 GeneratedPosition = new Vector3(Random.Range (-7, 7) , 5, -1);

		Instantiate (projectile, GeneratedPosition, transform.rotation);
	}
}