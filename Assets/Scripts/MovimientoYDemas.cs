using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoYDemas : MonoBehaviour
{
    Rigidbody2D fisicas;
    public float movX, movY;
    public float magnitudVelocidad = 4;
    private Color colorOriginal;
    SpriteRenderer sprite;
    private float tiempoDetenido = 2.0f;
    private float tiempoColision;
    private bool detener = false;
    void Start()
    {
        fisicas = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (detener && Time.time - tiempoColision >= tiempoDetenido)
        {
            Resetcolor();
            detener = false;
        }

        if (!detener)
        {
            float movimientoHorizontal = Input.GetAxis("Horizontal");
            float movimientoVertical = Input.GetAxis("Vertical");
            Vector2 movimiento = new Vector2(movimientoHorizontal * magnitudVelocidad , fisicas.velocity.y);

            fisicas.velocity = movimiento ;
        }
        else
        {
            fisicas.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Zona"))
        {
            sprite.color = Color.red;
            detener = true;
            tiempoColision = Time.time;
        }
    }

    private void Resetcolor()
    {
        sprite.color = colorOriginal;
    }
}
