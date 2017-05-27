using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // The force which is added when the player jumps
    // This can be changed in the Inspector window
    //public Vector2 jumpForce = new Vector2(0, 300);
    public Vector2 jumpForce = new Vector2(0, 300);
    public Transform grow;
    GameObject transformer;

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {            
            //Debug.Log(collision.gameObject.tag);            
            grow.localScale += new Vector3(0.015f,0.015f, 0);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
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

    // Die by collision
    //void OnCollisionEnter2D(Collision2D other)
    //{
   //     Die();
   // }

    void Die()
    {
        //Application.LoadLevel(Application.loadedLevel);        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}