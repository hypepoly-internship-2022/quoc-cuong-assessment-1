using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameMgr gameMgr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(){
        gameMgr.CompleteLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
