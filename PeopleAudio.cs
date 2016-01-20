using UnityEngine;
using System.Collections;

public class PeopleAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        GetComponent<AudioSource>().Play();
    }
}
