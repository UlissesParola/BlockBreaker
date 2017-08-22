using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public bool autoPlay;

    private Ball ball;

	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!autoPlay)
        {
            MoveWithMouse();
        }
        else
        {
            AutoPlay();
        }
	}

    void AutoPlay()
    {
        this.transform.position = new Vector3 (Mathf.Clamp (ball.transform.position.x, 0.75f, 15.25f), this.transform.position.y, 0f);
    }

    void MoveWithMouse()
    {
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

        this.transform.position = new Vector3 (Mathf.Clamp (mousePosInBlocks, 0.75f, 15.25f), this.transform.position.y, 0f);
    }
}
