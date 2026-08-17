using UnityEngine;

public class Movimiento_enemigo : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidad_enemigo = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = Vector3.back * velocidad_enemigo;
    }
}