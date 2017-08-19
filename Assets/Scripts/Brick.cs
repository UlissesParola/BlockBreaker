using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHit;
    public Sprite[] hitSprites;
    private LevelManager levelManager;
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
        else
        {
            LoadSprites();
        }
	}

    void LoadSprites()
    {
        int spriteIndex = hits - 1;
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
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
