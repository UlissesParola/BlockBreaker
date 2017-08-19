﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour {

    private LevelManager levelManager;
	// Use this for initialization
	void Start () {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		levelManager.LoadLevel ("Lose");
	}

}
