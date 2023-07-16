using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    Boolean gameHasEnded = false;

    public float restartdelay = 1f;

    public GameObject completelevelUI;
    public void completelevel ()
    {
        completelevelUI.SetActive(true);

    }

    public void Endgame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            //Restarted game
            Invoke("Restart", restartdelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
