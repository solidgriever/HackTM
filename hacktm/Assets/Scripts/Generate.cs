using UnityEngine;


public class Generate : MonoBehaviour
{
    public GameObject rocks;
    int score = 0;
    int timer = 30;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
    }

    void OnGUI()
    {
        Rect rect = new Rect(Screen.width - 120, 0, 100, 50);
        GUIStyle rightStyle = GUI.skin.GetStyle("Label");
        rightStyle.alignment = TextAnchor.UpperRight;
        GUI.color = Color.black;
        GUILayout.Label(" Score: " + score.ToString());        
        GUI.Label(rect, "Time: " + timer.ToString(), rightStyle);
    } 

    void CreateObstacle()
    {
        timer--;
        Instantiate(rocks);
        score+=5;
    }

   
}