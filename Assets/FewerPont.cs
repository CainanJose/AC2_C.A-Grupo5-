using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FewerPont : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "comida")
        {
            FindObjectOfType<Placar>().pontos--;

        }
    }
}

