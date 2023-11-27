using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Temporizador : MonoBehaviour
{
    public float temporizador = 0;

    public TextMeshProUGUI textoTiempo;
   
    void Update()
    {
        temporizador += Time.deltaTime;

        textoTiempo.text = "" + temporizador.ToString("f1");
    }
}
