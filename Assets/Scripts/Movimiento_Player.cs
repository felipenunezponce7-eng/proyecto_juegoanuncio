using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movimiento_Player : MonoBehaviour
{
    public float sensibilidad = 0.005f;
    public float limiteX = 8f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 posicion = transform.position;

                posicion.x += touch.deltaPosition.x * sensibilidad;

                posicion.x = Mathf.Clamp(
                    posicion.x,
                    -limiteX,
                    limiteX
                );

                transform.position = posicion;
            }
        }


    }
}