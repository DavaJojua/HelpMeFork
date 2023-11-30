using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
  

    public GameObject Player;
    public GameObject OriginalPoint;
    public GameObject RatingUI;
    public GameObject Intro;

    [Header("CDs")]
    [SerializeField]
    private GameObject CD1;
    [SerializeField]
    private GameObject CD2;
    [SerializeField]
    private GameObject CD3;
    [SerializeField]
    private GameObject CD4;
    [SerializeField]
    private GameObject CD5;

    [Header("PLaces")]
    [SerializeField]
    private GameObject Place1;
    [SerializeField]
    private GameObject Place2;
    [SerializeField]
    private GameObject Place3;
    [SerializeField]
    private GameObject Place4;
    [SerializeField]
    private GameObject Place5;

    void Update()
    {
        if (CD1.transform.position == Place1.transform.position && 
            CD2.transform.position == Place2.transform.position && 
            CD3.transform.position == Place3.transform.position && 
            CD4.transform.position == Place4.transform.position && 
            CD5.transform.position == Place5.transform.position)
        {         
                Player.transform.position = OriginalPoint.transform.position;
                Intro.SetActive(false);
                RatingUI.SetActive(true);
                CD1.transform.position = OriginalPoint.transform.position;
                CD1.SetActive(false);

        }
    }
}
