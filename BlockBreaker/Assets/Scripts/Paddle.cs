using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    // for automation testing
    public bool autoPlay = false;

    private Ball ball;

    private void Start()
    {
        ball = GameObject.FindObjectOfType<Ball>();
    }
    // Update is called once per frame
    void Update ()
    {
        if(!autoPlay)
        {
            MoveWithMouse();
        }
        else
        {
            AutoPlay();
        }
        
	}

    // automation testing
    void AutoPlay()
    {
        // keep original y position with this.transform.position.y
        Vector3 paddlePos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
        Vector3 ballPos = ball.transform.position;
        paddlePos.x = Mathf.Clamp(ballPos.x, 1.6f, 6.4f);
        this.transform.position = paddlePos;
    }

    void MoveWithMouse()
    {
        // keep original y position with this.transform.position.y
        Vector3 paddlePos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 1.6f, 6.4f);
        this.transform.position = paddlePos;
    }
}
