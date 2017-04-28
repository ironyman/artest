using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour {
    public float speed;
    public GameObject SphereToSpawn;
    public GUISkin projGui;

    private GameObject hiroObjRoot;
    private GameObject kanjiObjRoot;

    public int Score;
    // Use this for initialization
    void Start () {
        hiroObjRoot = GameObject.FindGameObjectWithTag("hiroObjRoot");
        kanjiObjRoot = GameObject.FindGameObjectWithTag("kanjiObjRoot");

        Score = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (hiroObjRoot.activeInHierarchy)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                InvokeRepeating("LaunchProjectile", 1.0f, 2.0f);
                LaunchProjectile();


            }
        }          


    }

    

    void LaunchProjectile()
    {
        GameObject Sphere = Instantiate(SphereToSpawn, hiroObjRoot.transform.position, hiroObjRoot.transform.rotation);
        Vector3 forceDir = Vector3.up;

        float dirUpX = Random.Range(-0.6f, 0.6f);
        float dirUpZ = Random.Range(0.1f, 0.6f);
        Sphere.GetComponent<Rigidbody>().AddForce(new Vector3(dirUpX, 1, dirUpZ) * speed);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 500, 500), "Score: " + Score, projGui.GetStyle("Label"));
    }
}
