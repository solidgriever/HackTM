using UnityEngine;


public class GenerateCoins : MonoBehaviour
{
    
        public GameObject coins0;
        public GameObject coins1;
        public GameObject coins2;
        public GameObject coins3;
        public GameObject coins4;
        public GameObject coins5;
        public GameObject coins6;
        public GameObject coins7;
        public GameObject coins8;
        public GameObject coins9;

    //[SerializeField]
    GameObject[] coins = new GameObject[10];   
    
    int score = 0;
    int timer = 30;
    public float timer2 = 0.0f;
    // Use this for initialization
    void Start()
    {
        coins[0] = coins0;
        coins[1] = coins1;
        coins[2] = coins2;
        coins[3] = coins3;
        coins[4] = coins4;
        coins[5] = coins5;
        coins[6] = coins6;
        coins[7] = coins7;
        coins[8] = coins8;
        coins[9] = coins9;
        for(int i = 0; i < 10; i++)
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
        if (timer < 6f)
            GUI.Label(rect2, timer.ToString(), rightStyle);
    }

    void CreateObstacle()
    {
        timer--;
        int i = timer / 3;
        Instantiate(coins[i]);
        
         
        score += 5;
    }


}