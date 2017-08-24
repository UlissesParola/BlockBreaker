using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class GameData {

    public static string difficult = "normal";
    public static float ballVelocity = 13f;
    public static int lifes = 3;

    public static void ResetLifes()
    {
        lifes = 3;
    }

}
