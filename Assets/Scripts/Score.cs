using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    private int puntos;
    public TextMeshProUGUI scoreText;
    public GameObject puerta;
    void Start()
    {
        puntos = 0;
    }

    void Update()
    {
        if(puntos == 2)
        {
            puerta.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Moneda")
        {
            puntos++;
            scoreText.text = "score " + puntos;
        }
    }
}
