using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ItemCollector : MonoBehaviour
{

    private int cherries = 0;

    [SerializeField] private Text cherriesText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Gifts: " + cherries;
            
            //if(SceneManager.GetActiveScene().buildIndex == 3)
            Timer.elapsedTime -= 1.0f;
            //else if(SceneManager.GetActiveScene().buildIndex == 4)
            //Timer2.elapsedTime -= 1.0f;
            //else if(SceneManager.GetActiveScene().buildIndex == 5)
            //Timer3.elapsedTime -= 1.0f;
        }
    }
}
