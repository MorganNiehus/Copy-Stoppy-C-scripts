using UnityEngine;
using System.Collections;

public class CopyMachineMain : MonoBehaviour {

    private bool onTrigger = false;
    public GameObject other;
    public AudioClip copierSound;


    // Use this for initialization
    void Start ()
    {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == ("Player"))
        {
            onTrigger = true;
        }
    }

    void OnTriggerExit()
    {
        onTrigger = false;
    }

    // Update is called once per frame
    void Update ()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                other.GetComponent<Animation>().Play();
                GetComponent<AudioSource>().Play();

                Destroy(GameObject.FindGameObjectWithTag("Enemy"));
                Debug.Log("enemies dead");
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.DeleteAll();
        }
    }
            


}
