using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueManager : MonoBehaviour
{
    
    [SerializeField]
    private int amountOfClues = 0;

    private int clues = 0;
    
    [SerializeField]
    private GameObject OriginalPoint;
    [SerializeField]
    private GameObject Player;
    [SerializeField] 
    private GameObject UI_Previous;
    [SerializeField] 
    private GameObject UI_New;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Clues")
        {
            clues++;
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if(clues == amountOfClues)
        {
            Debug.Log("You got all of the clues!");
            Player.transform.position = OriginalPoint.transform.position;
            UI_Previous.SetActive(false);
            UI_New.SetActive(true);
            amountOfClues = 0;
        }
    }
}
