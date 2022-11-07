using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMoveControl moveControl;
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Wall"){
            moveControl.enabled = false;
            FindObjectOfType<GameMgr>().GameOver();
        }
    }
}
