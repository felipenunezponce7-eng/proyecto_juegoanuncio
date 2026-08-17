using System.Collections.Generic;
using UnityEngine;

public class Balapool : MonoBehaviour

{
    public static Balapool Instance;

    public GameObject bulletPrefab;

    public int cantidadInicial = 100;

    private List<GameObject> pool =
        new List<GameObject>();

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        for (int i = 0; i < cantidadInicial; i++)
        {
            GameObject bala =
                Instantiate(
                    bulletPrefab,
                    transform
                );

            bala.SetActive(false);

            pool.Add(bala);
        }
    }

    public GameObject ObtenerBala()
    {
        foreach (GameObject bala in pool)
        {
            if (!bala.activeInHierarchy)
            {
                return bala;
            }
        }

        GameObject nuevaBala =
            Instantiate(
                bulletPrefab,
                transform
            );

        nuevaBala.SetActive(false);

        pool.Add(nuevaBala);

        return nuevaBala;
    }
}