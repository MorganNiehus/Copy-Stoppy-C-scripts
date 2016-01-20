using UnityEngine;
using System.Collections;

public class ComputerAction : MonoBehaviour
{



    private bool onTrigger = false;
    public int score = 0;
    public int totalScore = 0;
    public float timer = 10.0f;
    public int drunkModeCounter = 0;
    bool isAdded = false;

    public Transform startingPoint;


    public bool showGUI = false;

    public string nextLevel;
    public string currentLevel;



    private GUIStyle guiStyle1 = new GUIStyle();

    public Font fontSelected;

    public int quota = 50;

    // Use this for initialization
    void Awake()
    {
        PlayerPrefs.GetInt("totalScore");
        totalScore = PlayerPrefs.GetInt("totalScore");

        PlayerPrefs.GetInt("drunkModeCounter");
        drunkModeCounter = PlayerPrefs.GetInt("drunkModeCounter");
    }

    void OnTriggerEnter()
    {
        onTrigger = true;
    }

    void OnTriggerExit()
    {
        onTrigger = false;
        showGUI = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Main_Menu");
            Screen.lockCursor = false;
        }

        timer -= Time.deltaTime;
        RaycastHit hit;
        Ray computerRay = Camera.main.ViewportPointToRay(new Vector3(Screen.width / 2,Screen.height / 2,0f));

        if (onTrigger)
        {
            if (Physics.Raycast(computerRay, out hit))
            {
                if (hit.collider.tag == "Computer" || hit.collider.tag == "Button1" || hit.collider.tag == "Button2" || hit.collider.tag == "Button3" || hit.collider.tag == "Button4" || hit.collider.tag == "Button5" || hit.collider.tag == "Button6")
                {
                    showGUI = false;
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //score += 10;
                    }
                }
                else
                    showGUI = true;
            }
        }

        if (timer <= 0)
        {
            if (quota <= score)
            {
                Application.LoadLevel(nextLevel);
            }
            else
                Application.LoadLevel("GameOver_Quota");
            PlayerPrefs.DeleteAll();
        }

        if (nextLevel == "Victory")
        {
            PlayerPrefs.SetInt("drunkModeCounter", 5);
        }
    }

    void OnGUI()
    {
        guiStyle1.fontSize = 30;
        guiStyle1.font = fontSelected;
        guiStyle1.normal.textColor = Color.black;
        GUI.Label(new Rect(10, 10, 100, 20), "Time remaining: " + Mathf.RoundToInt(timer), guiStyle1);
        GUI.Label(new Rect(Screen.width - 200, Screen.height - 35, 200, 80), "Score: " + score, guiStyle1);
        GUI.Label(new Rect(0, Screen.height - 50, 100, 50), "Quota: " + quota, guiStyle1);
        GUI.Label(new Rect(Screen.width - 100, 0, 100, 50), currentLevel, guiStyle1);

        if (showGUI)
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 10, 40, 50), "Press the buttons!", guiStyle1);
    }

}
