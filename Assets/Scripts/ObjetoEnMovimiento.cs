using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoEnMovimiento : MonoBehaviour
{
    private float movY;
    bool haciaUnLado;
    public float Velocidad;
    
    void Update()
    {
        vigilarDireccion();
        mover();
    }

    void vigilarDireccion() 
    {
        if (transform.position.x > -10)
        {
            haciaUnLado = false;
        }

        else if (transform.position.x < -2)
        {
            haciaUnLado = true;
        } 
    }
    void mover()
    {
        if (haciaUnLado == true)
        {
            transform.Translate(Velocidad * Vector2.left * Time.deltaTime);
        }
        else
        {
            transform.Translate(Velocidad * Vector2.right * Time.deltaTime);
        }
    }
}
