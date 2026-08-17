using UnityEngine;

public class BuffDebuffSpawner : MonoBehaviour
{
    [Header("Jugador")]
    public Transform jugador;

    [Header("Prefabs")]
    public GameObject[] prefabs;

    [Header("Spawn")]
    public float tiempoEntreSpawns = 15f;
    public float distanciaFrenteJugador = 25f;

    private void Start()
    {
        InvokeRepeating(
            nameof(SpawnOpciones),
            tiempoEntreSpawns,
            tiempoEntreSpawns
        );
    }

    void SpawnOpciones()
    {
        if (prefabs.Length < 2)
        {
            Debug.LogWarning(
                "Necesitas al menos 2 prefabs."
            );
            return;
        }

        int indiceIzq =
            Random.Range(0, prefabs.Length);

        int indiceDer =
            Random.Range(0, prefabs.Length);

        while (indiceDer == indiceIzq)
        {
            indiceDer =
                Random.Range(
                    0,
                    prefabs.Length
                );
        }

        float z =
            jugador.position.z +
            distanciaFrenteJugador;

        Vector3 posicionIzquierda =
            new Vector3(-2.5f, 2f, z);

        Vector3 posicionDerecha =
            new Vector3(2.5f, 2f, z);

        Instantiate(
            prefabs[indiceIzq],
            posicionIzquierda,
            Quaternion.Euler(0, 180, 0)
        );

        Instantiate(
            prefabs[indiceDer],
            posicionDerecha,
            Quaternion.Euler(0, 180, 0)
        );
    }
}