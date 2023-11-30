using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipInsertion : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [Header("1")]
    [SerializeField]
    private GameObject TP1;

    [SerializeField]
    private GameObject chip1;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "chip1")
        {
            player.transform.position = TP1.transform.position;
            Destroy(chip1);
        }
    }

}
