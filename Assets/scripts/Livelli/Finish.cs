using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Finish : MonoBehaviour
{

    private AudioSource finishSound;

    

    private bool levelCompleted = false;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Personaggio" && !levelCompleted)
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 1f);    
        }
    }

    private void CompleteLevel(){
        //se completo il livello 3, devo inviare il tempo pk ho completato il gioco
        if(SceneManager.GetActiveScene().buildIndex == 3){

            Play_Leaderboard.SendLeaderboard(Timer.score);
        }
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
            }

}
