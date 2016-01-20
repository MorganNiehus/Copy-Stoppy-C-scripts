using UnityEngine;
using System.Collections;

public class Computer : MonoBehaviour {

    public Transform startingPoint;

    public GameObject computerText;

    bool canPress1 = false;
    bool canPress2 = false;
    bool canPress3 = false;

    bool canPress4 = false;
    bool canPress5 = false;
    bool canPress6 = false;

    public GameObject gbutton1;
    public GameObject gbutton2;
    public GameObject gbutton3;

    public GameObject gbutton4;
    public GameObject gbutton5;
    public GameObject gbutton6;



    public ComputerAction computerAction;
    
    // Use this for initialization
	void Awake () {

        GameObject computer = GameObject.FindGameObjectWithTag("ComputerMain");
        computerAction = computer.GetComponent<ComputerAction>();

        PlayerPrefs.GetInt("totalScore");
	}

    // Update is called once per frame
    void Update()
    {
        int rng = Random.Range(0, 5);
        int buttonRng = Random.Range(1, 3);

        StartCoroutine(buttonReady());

        RaycastHit hit;
        Ray computerRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        Debug.DrawLine(startingPoint.position, startingPoint.forward, Color.white, 1000.0f, true);
        if (Physics.Raycast(computerRay, out hit))
        {
            if (hit.collider.tag == "Button1")
            {
                computerAction.showGUI = false;
                if (canPress1 == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        computerText.GetComponent<TextMesh>().text = "work!";
                        GetComponent<AudioSource>().Play();
                        computerAction.score++;
                        computerAction.totalScore++;
                    }
                }

            }
            if (hit.collider.tag == "Button2")
            {
                computerAction.showGUI = false;
                if (canPress2 == true)
                {

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        computerText.GetComponent<TextMesh>().text = "Numbers!";
                        GetComponent<AudioSource>().Play();
                        computerAction.score++;
                        computerAction.totalScore++;
                    }
                }

            }
            if (hit.collider.tag == "Button3")
            {
                computerAction.showGUI = false;
                if (canPress3 == true)
                {
   
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        computerText.GetComponent<TextMesh>().text = "Business!";
                        GetComponent<AudioSource>().Play();
                        computerAction.score++;
                        computerAction.totalScore++;
                    }
                }

            }
            if (hit.collider.tag == "Button4")
            {
                computerAction.showGUI = false;
                if (canPress4 == true)
                {

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        computerText.GetComponent<TextMesh>().text = "3.1459";
                        GetComponent<AudioSource>().Play();
                        computerAction.score++;
                        computerAction.totalScore++;
                    }
                }

            }
            if (hit.collider.tag == "Button5")
            {
                computerAction.showGUI = false;
                if (canPress5 == true)
                {

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        computerText.GetComponent<TextMesh>().text = "Input file!";
                        GetComponent<AudioSource>().Play();
                        computerAction.score++;
                        computerAction.totalScore++;
                    }
                }

            }
            if (hit.collider.tag == "Button6")
            {
                computerAction.showGUI = false;
                if (canPress6 == true)
                {

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        computerText.GetComponent<TextMesh>().text = "ass kissing";
                        GetComponent<AudioSource>().Play();
                        computerAction.score++;
                        computerAction.totalScore++;
                    }
                }

            }
            


            if (Input.GetKeyDown(KeyCode.P))
            {
                PlayerPrefs.DeleteAll();
            }
        }
        PlayerPrefs.SetInt("totalScore", computerAction.totalScore);
    }

    IEnumerator buttonReady()
    {
        int rng = Random.Range(1, 125);


        int button1 = 1;
        int button2 = 2;
        int button3 = 3;

        int button4 = 4;
        int button5 = 5;
        int button6 = 6;


        if (button1 == rng)
        {
            Debug.Log("Button1!");
            gbutton1.GetComponent<Renderer>().material.color = Color.green;
            gbutton2.GetComponent<Renderer>().material.color = Color.white;
            gbutton3.GetComponent<Renderer>().material.color = Color.white;
            gbutton4.GetComponent<Renderer>().material.color = Color.white;
            gbutton5.GetComponent<Renderer>().material.color = Color.white;
            gbutton6.GetComponent<Renderer>().material.color = Color.white;
            canPress1 = true;
            canPress2 = false;
            canPress3 = false;
            canPress4 = false;
            canPress5 = false;
            canPress6 = false;
            yield return new WaitForSeconds(3);
        }

        if (button2 == rng)
        {
            Debug.Log("Button2!");
            gbutton1.GetComponent<Renderer>().material.color = Color.white;
            gbutton2.GetComponent<Renderer>().material.color = Color.green;
            gbutton3.GetComponent<Renderer>().material.color = Color.white;
            gbutton4.GetComponent<Renderer>().material.color = Color.white;
            gbutton5.GetComponent<Renderer>().material.color = Color.white;
            gbutton6.GetComponent<Renderer>().material.color = Color.white;
            canPress2 = true;
            canPress1 = false;
            canPress3 = false;
            canPress4 = false;
            canPress5 = false;
            canPress6 = false;
            yield return new WaitForSeconds(3);
        }

        if (button3 == rng)
        {
            Debug.Log("Button3!");
            gbutton1.GetComponent<Renderer>().material.color = Color.white;
            gbutton2.GetComponent<Renderer>().material.color = Color.white;
            gbutton3.GetComponent<Renderer>().material.color = Color.green;
            gbutton4.GetComponent<Renderer>().material.color = Color.white;
            gbutton5.GetComponent<Renderer>().material.color = Color.white;
            gbutton6.GetComponent<Renderer>().material.color = Color.white;
            canPress3 = true;
            canPress2 = false;
            canPress1 = false;
            canPress4 = false;
            canPress5 = false;
            canPress6 = false;
            yield return new WaitForSeconds(3);
        }

        if (button4 == rng)
        {
            Debug.Log("Button4!");
            gbutton1.GetComponent<Renderer>().material.color = Color.white;
            gbutton2.GetComponent<Renderer>().material.color = Color.white;
            gbutton3.GetComponent<Renderer>().material.color = Color.white;
            gbutton4.GetComponent<Renderer>().material.color = Color.green;
            gbutton5.GetComponent<Renderer>().material.color = Color.white;
            gbutton6.GetComponent<Renderer>().material.color = Color.white;
            canPress4 = true;
            canPress3 = false;
            canPress2 = false;
            canPress1 = false;
            canPress5 = false;
            canPress6 = false;
            yield return new WaitForSeconds(3);
        }
        if (button5 == rng)
        {
            Debug.Log("Button5!");
            gbutton1.GetComponent<Renderer>().material.color = Color.white;
            gbutton2.GetComponent<Renderer>().material.color = Color.white;
            gbutton3.GetComponent<Renderer>().material.color = Color.white;
            gbutton4.GetComponent<Renderer>().material.color = Color.white;
            gbutton5.GetComponent<Renderer>().material.color = Color.green;
            gbutton6.GetComponent<Renderer>().material.color = Color.white;
            canPress5 = true;
            canPress3 = false;
            canPress2 = false;
            canPress1 = false;
            canPress4 = false;
            canPress6 = false;
            yield return new WaitForSeconds(3);
        }

        if (button6 == rng)
        {
            Debug.Log("Button6!");
            gbutton1.GetComponent<Renderer>().material.color = Color.white;
            gbutton2.GetComponent<Renderer>().material.color = Color.white;
            gbutton3.GetComponent<Renderer>().material.color = Color.white;
            gbutton4.GetComponent<Renderer>().material.color = Color.white;
            gbutton5.GetComponent<Renderer>().material.color = Color.white;
            gbutton6.GetComponent<Renderer>().material.color = Color.green;
            canPress6 = true;
            canPress3 = false;
            canPress2 = false;
            canPress1 = false;
            canPress4 = false;
            canPress5 = false;
            yield return new WaitForSeconds(3);
        }

    }
}
