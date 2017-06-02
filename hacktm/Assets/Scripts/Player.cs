using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	//public Vector2 jumpForce = new Vector2(0, 300);
	public Vector2 jumpForce = new Vector2(0, 300);
	public Transform grow;
	//public SpriteRenderer renderer;
	public int timer = 0;
	public float timer2 = 0.0f;
	public AudioSource efxSource;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ground")
		{

			//efxSource.play();

			//Debug.Log(collision.gameObject.tag);            
			grow.localScale += new Vector3(0.015f,0.015f, 0);

		}

	}
	void Start()
	{
		efxSource = GetComponent<AudioSource>();
		InvokeRepeating("Count", 1f, 1.5f);
	}
	// Update is called once per frame
	void Update()
	{

		//Change ball color randomly
		//timer2 += Time.deltaTime;
		//if (timer >= 2.0f)//change the float value here to change how long it takes to switch.
		//{
		// pick a random color
		//     Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
		// apply it on current object's material
		//      gameObject.GetComponent<Renderer>().material.color = newColor;
		//     timer2 = 0;
		// }
		// Jump

		if (Input.GetMouseButtonDown(0) || Input.GetKeyUp("space"))
		{
			//GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}

		// Die by being off screen
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0 || screenPosition.x < -10)
		{
			Die();
		}


	}
	void Count()
	{
		timer++;        

	}
	// Die by collision
	//void OnCollisionEnter2D(Collision2D other)
	//{
	//     Die();
	// }

	public void Die()
	{
		if(timer > 1)
			SceneManager.LoadScene("Load2");
		else
			//Application.LoadLevel(Application.loadedLevel);        
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}