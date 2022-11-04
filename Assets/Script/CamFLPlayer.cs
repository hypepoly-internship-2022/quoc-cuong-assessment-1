using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFLPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 distanceCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.position + distanceCam;
    }
}
