using UnityEngine;
using UnityEngine.SceneManagement;


public class Arcade : MonoBehaviour
{


    public float timer2 = 0.0f;

 
    // Update is called once per frame
    void Update()
	{

		//Change ball color randomly
		timer2 += Time.deltaTime;
		if (timer2 >= 0.2f)//change the float value here to change how long it takes to switch.
		{
		 //pick a random color
		     Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
		// apply it on current object's material
		      gameObject.GetComponent<Renderer>().material.color = newColor;
		     timer2 = 0;
		 }
			
}
}
