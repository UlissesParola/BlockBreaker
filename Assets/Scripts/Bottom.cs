using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bottom : MonoBehaviour {

    public int life;

    private Image[] lifeImage;
    private Ball ball;
    private LevelManager levelManager;
    	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        lifeImage = GameObject.FindObjectsOfType<Image>();
        life = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
        if (life <= 0)
        {
            levelManager.LoadLevel("Lose");
        }
        else
        {
            life--;
            Destroy(lifeImage[life]);
            ball.StartingGame();

        }
		
	}

}
