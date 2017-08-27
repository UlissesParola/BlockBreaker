using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseCollider : MonoBehaviour {

    private Image[] lifeImage;
    private Ball ball;
    private LevelManager levelManager;

    	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();

        lifeImage = LoadingLifeImages(GameObject.FindObjectsOfType<Image>(), GameData.lifes); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
        if (GameData.lifes < 1)
        {
            levelManager.LoadLevel("Lose");
        }
        else
        {
            GameData.lifes--;
            Destroy(lifeImage[GameData.lifes]);
            ball.StartingGame();

        }
	}

    Image[] LoadingLifeImages(Image[] unsortedLifes, int lifes)
    {   
        Image[] lifeImageTemp = new Image[3];

        for (int i = 0; i < lifeImageTemp.Length; i++)
        {
            if (unsortedLifes[i].name == "Life1")
            {
                lifeImageTemp[0] = unsortedLifes[i];
            }
            else if (unsortedLifes[i].name == "Life2")
            {
                lifeImageTemp[1] = unsortedLifes[i];
            }
            else
            {
                lifeImageTemp[2] = unsortedLifes[i];
            }
        }
            

        for (int i = 2; i > lifes-1; i--)
        {
            Destroy(lifeImageTemp[i]);
        }
            
        return lifeImageTemp;
    }

}
