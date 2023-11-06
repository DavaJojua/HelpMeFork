using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCreepyRoom2 : MonoBehaviour
{
    public GameObject player;
    public GameObject TPCR;
    // Start is called before the first frame update
    private void OnTriggerEvent(Collider other) 
    {
        player.transform.position = TPCR.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
