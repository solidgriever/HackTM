using UnityEngine;


public class Generate : MonoBehaviour
{
    public GameObject rocks;
    public GameObject rocks2;
    public GameObject rocks3;
    public GameObject rocks4;
    public GameObject rocks5;
    public GameObject rocks6;
    public GameObject rocks7;


    int score = 0;
    int timer = 30;
    public float timer2 = 0.0f;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);       
    }

    void OnGUI()
    {
        

        Rect rect = new Rect(Screen.width - 120, 0, 100, 50);
        Rect rect2 = new Rect(Screen.width / 2 - 50, 0, 100, 50);
        GUIStyle rightStyle = GUI.skin.GetStyle("Label");
        rightStyle.fontSize = 20;
        rightStyle.alignment = TextAnchor.UpperRight;
        GUI.color = Color.white;
        
        GUILayout.Label(" Score: " + score.ToString());
        GUI.Label(rect, "Time: " + timer.ToString(), rightStyle);
        if(timer<6f)
            GUI.Label(rect2, timer.ToString(), rightStyle);
    }

    void CreateObstacle()
    {
        timer--;
        if (timer % 5 == 0)
            Instantiate(rocks3);
        else if (timer % 3 == 0)
        {            
            if (Random.value < 0.5f)
                Instantiate(rocks2);
            else 
                Instantiate(rocks4);           
        }
        else if(timer % 2 == 0)
        {            
            if (Random.value < 0.5f)
                Instantiate(rocks);            
            else
                Instantiate(rocks7);        }
        else
        {
            if (Random.value < 0.5f)
                Instantiate(rocks5);
            else  
                Instantiate(rocks3);            
        }
        score += 5;
    }

   
}