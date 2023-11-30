using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipInsertion2 : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

 
    [Header("2")]
    [SerializeField]
    private GameObject TP2;

    [SerializeField]
    private GameObject chip2;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "chip2")
        {
            player.transform.position = TP2.transform.position;
            Destroy(chip2);
        }
    }
}
