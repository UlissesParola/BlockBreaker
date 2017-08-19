using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private LevelManager levelManager;
    public int maxHit;
    private int hits;

	// Use this for initialization
	void Start () {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (hits >= maxHit)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        hits++;
    }

    //TODO remove this method after the mechanics of winning the game is done
    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }

}
