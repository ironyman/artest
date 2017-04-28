using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public GUISkin projGui;
    public float speed;

    private int Score, CompScore;
    float sx;
    float sz;

    Vector3 respawnPos;
	// Use this for initialization
	void Start () {
        Score = 0;
        CompScore = 0;
        respawnPos = transform.localPosition;

        sx = Random.Range(0, 2) == 0 ? -1 : 1;
        sz = Random.Range(0, 2) == 0 ? -1 : 1;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(5, 10) * sx * speed,  0, Random.Range(5, 10) * sz * speed);

    }
	
	// Update is called once per frame
	void Update () {

   
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "playerBoundary")
        {
            CompScore++;
            transform.localPosition = respawnPos;
        }
        else if (other.tag == "compBoundary")
        {
            Score++;
            transform.localPosition = respawnPos;
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, Screen.width, 100), "Your Score: " + Score, projGui.GetStyle("Label"));
        GUI.Label(new Rect(0, 100, Screen.width, 100), "Computer Score: " + CompScore, projGui.GetStyle("Label"));
    }
}
