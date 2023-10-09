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


    [Header("2")]
    [SerializeField]
    private GameObject TP2;

    [SerializeField]
    private GameObject chip2;

    [Header("3")]
    [SerializeField]
    private GameObject TP3;

    [SerializeField]
    private GameObject chip3;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "chip1")
        {
            player.transform.position = TP1.transform.position;
            Destroy(chip1);
        }

        if (other.gameObject.name == "chip2")
        {
            player.transform.position = TP2.transform.position;
            Destroy(chip2);
        }

        if (other.gameObject.name == "chip3")
        {
            player.transform.position = TP3.transform.position;
            Destroy(chip3);
        }
    }

}
