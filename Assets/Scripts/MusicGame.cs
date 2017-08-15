using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicGame : MonoBehaviour {
	public static MusicGame instance;

	void Awake(){
		if (instance != null) 
		{
			Destroy (gameObject);
		} 
		else 
		{
			instance = this;	
			DontDestroyOnLoad(gameObject);
		}
	}

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
