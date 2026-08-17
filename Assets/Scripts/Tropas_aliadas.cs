using UnityEngine;

public class Tropas_aliadas : MonoBehaviour
{
    private Transform jugador;
    private Vector3 offset;

    public float velocidadSeguimiento = 8f;

    public void SetTarget(
        Transform nuevoJugador,
        Vector3 nuevoOffset)
    {
        jugador = nuevoJugador;
        offset = nuevoOffset;
    }

    void Update()
    {
        if (jugador == null)
            return;

        Vector3 objetivo =
            jugador.position + offset;

        transform.position =
            Vector3.Lerp(
                transform.position,
                objetivo,
                velocidadSeguimiento * Time.deltaTime
            );
    }
}