using System.Collections.Generic;
using UnityEngine;

public class Army_Aliados : MonoBehaviour
{
    public static Army_Aliados Instance;

    public GameObject troopPrefab;
    public Transform jugador;

    public List<Tropas_aliadas> tropas =
        new List<Tropas_aliadas>();

    [Header("Formación")]
    public float distanciaEntreCapas = 1.5f;
    public int tropasPorCapa = 8;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        AgregarTropas(0);
    }

    public void AgregarTropas(int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            GameObject nuevaTropa =
                Instantiate(
                    troopPrefab,
                    jugador.position,
                    transform.rotation
                );

            Tropas_aliadas follower =
                nuevaTropa.GetComponent<Tropas_aliadas>();

            tropas.Add(follower);
        }

        ActualizarFormacion();
    }

    public void ActualizarFormacion()
    {
        for (int i = 0; i < tropas.Count; i++)
        {
            int capa =
                (i / tropasPorCapa) + 1;

            int indiceEnCapa =
                i % tropasPorCapa;

            float angulo =
                (360f / tropasPorCapa) * indiceEnCapa;

            float radio =
                capa * distanciaEntreCapas;

            Vector3 offset = new Vector3(
                Mathf.Cos(angulo * Mathf.Deg2Rad),
                0,
                Mathf.Sin(angulo * Mathf.Deg2Rad)
            ) * radio;

            tropas[i].SetTarget(
                jugador,
                offset
            );
        }
    }
    public void DestruirTropas(int cantidad)
    {
        cantidad = Mathf.Min(cantidad, tropas.Count);

        for (int i = 0; i < cantidad; i++)
        {
            Tropas_aliadas tropa =
                tropas[tropas.Count - 1];

            Destroy(tropa.gameObject);

            tropas.RemoveAt(tropas.Count - 1);
        }

        ActualizarFormacion();
    }
}