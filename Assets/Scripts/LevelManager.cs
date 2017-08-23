using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string scene)
	{
		SceneManager.LoadScene(scene);
        if (scene == "Start")
        {
            GameData.lifes = 3;
        }
        Brick.brickCount = 0;
	}	

	public void QuitGame()
	{
		Application.Quit();
	}	

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Brick.brickCount = 0;
    }

    public void BricksDestroied()
    {
        if (Brick.brickCount <= 0)
        {
            LoadNextLevel();
        }
    }
}
