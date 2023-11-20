using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Comida : MonoBehaviour
{
    private Vector3 posicaoInicial;
    private Quaternion rotacaoInicial;
    

    public void Start(){
        posicaoInicial = this.transform.position;
        rotacaoInicial = this.transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "chao")
        {
            FindObjectOfType<Placar>().pontos--;
            FindObjectOfType<Placar>().atualizar();
            this.transform.position = posicaoInicial;
            this.transform.rotation = rotacaoInicial;

        }

        if (other.gameObject.tag == "lixo")
        {
            this.transform.position = posicaoInicial;
            this.transform.rotation = rotacaoInicial;
        }

        if (other.gameObject.tag == "mesa")
        {
            FindObjectOfType<Placar>().pontos++;
            FindObjectOfType<Placar>().atualizar();
            this.transform.position = posicaoInicial;
            this.transform.rotation = rotacaoInicial;
        }

    }


}
