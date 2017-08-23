using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultSelected : MonoBehaviour {
    private Text text;
	// Use this for initialization
	void Start () {
        text = gameObject.GetComponent<Text>();
        SetText();

	}
	
	// Update is called once per frame
	void Update () {
        SetText();
	}

    void SetText()
    {
        if (GameData.ballVelocity == 10f)
        {
            text.text = "Easy";
        }
        else if (GameData.ballVelocity == 13f)
        {
            text.text = "Normal";
        }
        else
        {
            text.text = "Hard";
        }

    }
}
