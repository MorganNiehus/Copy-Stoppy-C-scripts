using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public bool isBack = false;
    public bool isInstructions = false;
    public bool isNewGame = false;
    public bool drunkModeIsUnlocked = false;
    public bool isDrunkMode = false;

    public GUIStyle guiStyle = new GUIStyle();

    int drunkModeCounter = 0;

    private Animator anim;

    public GameObject cam;



    void Awake()
    {
        PlayerPrefs.GetInt("totalScore");
        Screen.lockCursor = false;
    }
    
    void OnMouseEnter()
    {
        Debug.Log("green");
        GetComponent<TextMesh>().color = Color.green;
    }
    void OnMouseExit()
    {
        GetComponent<TextMesh>().color = Color.black;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("drunkModeCounter") == 5)
        {
            drunkModeIsUnlocked = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnMouseDown()
    {
        if (isInstructions)
        {
            cam.GetComponent<Animation>().Play("Instruction_Pan_In");
        }
        if (isBack)
        {
            cam.GetComponent<Animation>().Play("Instruction_Pan_Out");
        }
        if(isNewGame)
        {
            PlayerPrefs.DeleteAll();
            Application.LoadLevel("Level1");
        }
        if (isDrunkMode)
        {
            if(drunkModeIsUnlocked)
            {
                Application.LoadLevel("DrunkMode");
            }
        }
    }

    void OnGUI()
    {
        guiStyle.normal.textColor = Color.black;
        GUI.Label(new Rect(0, Screen.height - 20, 100, 50), "Version 1.0.1 Alpha", guiStyle);
        Debug.Log("GUI is on");
    }

}
