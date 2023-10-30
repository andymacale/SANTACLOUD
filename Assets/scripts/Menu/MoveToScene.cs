using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   
    public void MoveToScene(int sceneID)
    {
        
        SceneManager.LoadScene(sceneID);
        //if(sceneID == 5){
         //   Play_Leaderboard.GetLeaderboard();
       // }
    }
}
