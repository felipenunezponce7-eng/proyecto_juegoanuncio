using System.Collections.Generic;
using UnityEngine;

public class EnemyPoll : MonoBehaviour
{
    public static EnemyPoll Instance;

    public GameObject enemyPrefab;
    public int cantidadInicial = 200;

    private List<GameObject> enemigos =
        new List<GameObject>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < cantidadInicial; i++)
        {
            GameObject enemigo =
                Instantiate(enemyPrefab, transform);

            enemigo.SetActive(false);

            enemigos.Add(enemigo);
        }
    }

    public GameObject ObtenerEnemigo()
    {
        foreach (GameObject enemigo in enemigos)
        {
            if (!enemigo.activeInHierarchy)
            {
                return enemigo;
            }
        }

        GameObject nuevo =
            Instantiate(enemyPrefab, transform);

        nuevo.SetActive(false);

        enemigos.Add(nuevo);

        return nuevo;
    }
}