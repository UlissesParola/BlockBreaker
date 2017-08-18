using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Paddle paddle;
	private Vector3 ballToPaddleVector;
	private bool hasStarted;
	private Rigidbody2D ballRigidbody2D;

	// Use this for initialization
	void Start () 
	{
		ballRigidbody2D = GetComponent<Rigidbody2D> ();
        ballToPaddleVector = this.transform.position - paddle.transform.position;
		hasStarted = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!hasStarted)
		{
			this.transform.position = paddle.transform.position + ballToPaddleVector;
		
			if (Input.GetMouseButtonDown(0))
			{
                float XVelocity = Random.Range(-3, 4);
				hasStarted = true;
                ballRigidbody2D.velocity = new Vector2((float)XVelocity, 13f);
			}
		}
            


        Debug.Log("x " + ballRigidbody2D.velocity.x);
        Debug.Log("y " + ballRigidbody2D.velocity.y);
	}
		
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Paddle"))
        {
            Debug.Log("Velocidade adicionada");
            ballRigidbody2D.velocity = new Vector2(ballRigidbody2D.velocity.x, 13f);
        }
    }
}
