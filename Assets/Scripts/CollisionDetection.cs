using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {
    public GameObject Particles;
    SphereSpawner SS;
	// Use this for initialization
	void Start () {
        SS = GameObject.FindGameObjectWithTag("GameController").GetComponent<SphereSpawner>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        SS.Score++;
        Instantiate(Particles);
    }
}
