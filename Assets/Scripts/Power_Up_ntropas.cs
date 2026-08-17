using UnityEngine;

public class Power_Up_ntropas : MonoBehaviour
{
    public int cantidad = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PowerUp activado");

            Army_Aliados.Instance.AgregarTropas(cantidad);

            Destroy(gameObject);
        }
    }
}