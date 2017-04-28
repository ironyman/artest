using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongAIController : MonoBehaviour {

    public GameObject ball;

    private float paddle_x, paddle_y, paddle_z;

    public float followSpeed;
    private Vector3 velo = Vector3.zero;
	// Use this for initialization
	void Start () {
        paddle_x = gameObject.transform.localPosition.x;
        paddle_y = gameObject.transform.localPosition.y;
        paddle_z = gameObject.transform.localPosition.z;

    }
	
	// Update is called once per frame
	void Update () {
        float Ball_y = ball.transform.localPosition.y;
        //ball.transform.

        
        //transform.localPosition = new Vector3(paddle_x, Ball_y, paddle_z);

        transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(paddle_x, Ball_y, paddle_z), ref velo, followSpeed);

        Debug.Log(Ball_y);


    }
}
