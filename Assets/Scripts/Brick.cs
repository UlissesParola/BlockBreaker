using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public int maxHit;
    private int hits;
	// Use this for initialization
	void Start () {
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
}
