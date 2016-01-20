using UnityEngine;
using System.Collections;

public class GameOverCopier : MonoBehaviour {

    private bool onTrigger = false;

    public GameObject enemy;

	// Use this for initialization
	void Start ()
    {

	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT");
        if (other.gameObject.tag == "Enemy")
        {
            
            onTrigger = true;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (onTrigger == true)
        {
            Debug.Log("Scene Loaded");
            PlayerPrefs.DeleteKey("drunkModeCounter");
            Application.LoadLevel("GameOver_Final");
        }
	}
}
