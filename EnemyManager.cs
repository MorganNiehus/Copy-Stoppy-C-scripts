using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
    public int count = 0;
    public GameObject enemy;
    public int range1 = 0;
    public int range2 = 50;

    

	
    // Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        int rng = Random.Range(range1, range2);

        if (rng == 4)
        {
            Instantiate(enemy, transform.position, transform.rotation);
        }
        else
            rng = 0;
    }
}
