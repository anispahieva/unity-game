﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public void EndGame() {
        //logs game over in 
        if(!gameHasEnded) {

         gameHasEnded = true;
         Debug.Log("Game Over");
         Invoke("Restart", restartDelay);
        }

    }
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
