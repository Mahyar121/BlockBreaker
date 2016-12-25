using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Paddle paddle;

    private bool hasStarted = false;
    private Vector3 paddleToBallVector;
    private Vector3 startPos;

	// Use this for initialization
	void Start ()
    {
        paddle = GameObject.FindObjectOfType<Paddle>();
        // difference between ball location and paddle location
        paddleToBallVector = this.transform.position - paddle.transform.position;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!hasStarted)
        {
            // Lock the ball relative to the paddle
            this.transform.position = paddle.transform.position + paddleToBallVector;
            startPos = this.transform.position;
            // Wait for a mouse press to launch
            if (Input.GetKeyDown(KeyCode.Space))
            {
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }
       
	}
}
