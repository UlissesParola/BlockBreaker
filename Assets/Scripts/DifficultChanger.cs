using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultChanger : MonoBehaviour {

    public Text difficultSelectedText;

	// Use this for initialization
    public void ChangeDifficult(string difficult)
    {
        GameData.difficult = difficult;
        if (difficult == "Easy")
        {
            GameData.ballVelocity = 10f;
        }
        else if (difficult == "Normal")
        {
            GameData.ballVelocity = 13f;
        }
        else
        {
            GameData.ballVelocity = 16f;
        }
    }
}
