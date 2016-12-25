using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {


	// Update is called once per frame
	void Update ()
    {
        // keep original y position with this.transform.position.y
        Vector3 paddlePos = new Vector3(4.1f, this.transform.position.y, 0f);
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.4f, 7.7f);
        this.transform.position = paddlePos;
        
	}
}
