using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMgr : MonoBehaviour
{

    private bool checkGameOver = false;

    public float reStartDelay = 1.5f;

    public GameObject completeLevelUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CompleteLevel(){
        Debug.Log("Game Complete!!");
        completeLevelUI.active = true;
    }

    public void GameOver(){
        if(checkGameOver == false){
            checkGameOver = true;
            Debug.Log("Game Over!!");
            Invoke("ReStart", reStartDelay);
        }
    }

    void ReStart(){
        SceneManager.LoadScene("Level1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
