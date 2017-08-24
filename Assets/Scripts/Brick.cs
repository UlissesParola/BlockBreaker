using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public Sprite[] hitSprites;
    public static int brickCount = 0;
    public AudioClip crack;
    public GameObject smoke;

    private bool isBreakable;
    private LevelManager levelManager;
    private int hits;


	// Use this for initialization
	void Start () {
        levelManager = GameObject.FindObjectOfType<LevelManager>();

        isBreakable = (this.tag == "Breakable");
        if (isBreakable)
        {
            brickCount++;
        }
           
    }
	
	// Update is called once per frame
	void Update () {

	}

    void LoadSprites()
    {
        int spriteIndex = hits - 1;

        //testing if the sprite is really there before changing the image
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
        else
        {
            Debug.LogError("Missing sprite");
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBreakable)
        {
            HandleHits();
        }
    }

    void HandleHits()
    {
        int maxHit = hitSprites.Length + 1;
        hits++;

        if (hits >= maxHit)
        {
            //the decreasing of the counter should be before the Destroy method because the time this method takes to process 
            brickCount--;
            levelManager.BricksDestroied();
            //use the static method of the AudioSource class to play the sound when
            AudioSource.PlayClipAtPoint(crack, transform.position, 1f);
            SmokeEffect();
            Destroy(gameObject);


        }
        else
        {
            LoadSprites();
        }
    }

    private void SmokeEffect()
    {
        GameObject smokeInstance = Instantiate(smoke, gameObject.transform.position, Quaternion.identity);
        ParticleSystem.MainModule smokeParticle = smokeInstance.GetComponent<ParticleSystem>().main;
        smokeParticle.startColor = gameObject.GetComponent<SpriteRenderer>().color;
        smokeInstance.GetComponent<ParticleSystem>().Play();
    }

}
