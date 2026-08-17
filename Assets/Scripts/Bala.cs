using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 20f;
    public int daño = 1;

    private void OnEnable()
    {
        daño = Master.Instance.dañoJugador;

        CancelInvoke();

        Invoke(nameof(Desactivar), 3f);
    }

    void Update()
    {
        transform.Translate(
            Vector3.forward *
            velocidad *
            Time.deltaTime
        );
    }

    private void OnTriggerEnter(Collider other)
    {
        Vida_Enemigo enemigo =
            other.GetComponent<Vida_Enemigo>();

        if (enemigo != null)
        {
            enemigo.RecibirDaño(daño);

            Desactivar();
        }
    }

    void Desactivar()
    {
        gameObject.SetActive(false);
    }
}