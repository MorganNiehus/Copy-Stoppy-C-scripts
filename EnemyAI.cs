using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    private Transform target;
   
    public float speed;

	// Use this for initialization
	void Start ()
    {
        target = GameObject.FindGameObjectWithTag("base").GetComponent<Transform>();
    }

	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(target);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
}
