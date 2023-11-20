using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Placar : MonoBehaviour
{
    public int pontos = 0;
    public TextMeshProUGUI text;


    private void Start()
    {
        text.text = "Pontos: 0";
    }

    // private void Update()
    // {
    //     text.text = "Pontos: " + pontos.ToString();
    // }

    public void atualizar()
    {
          text.text = "Pontos: " + pontos.ToString();
    }
}