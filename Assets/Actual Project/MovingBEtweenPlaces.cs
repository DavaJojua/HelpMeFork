using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class MovingBEtweenPlaces : MonoBehaviour
{
    private void OnCollisionEnter(Collision chip1)
    {
        if (chip1.gameObject.name == "GoodOne")
        {
            Debug.Log("FUck");
        }
    }
}
   
