
using UnityEngine;

public class Power_Up_Daño : MonoBehaviour
{
    public int aumentodedaño;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Debug.Log("PowerUp activado");


            Master.Instance.dañoJugador += aumentodedaño;

            Destroy(gameObject);
        }
    }

}
 