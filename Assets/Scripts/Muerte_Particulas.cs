using UnityEngine;

public class Muerte_Particulas : MonoBehaviour
{
    public float tiempo = 1f;

    void Start()
    {
        Destroy(gameObject, tiempo);
    }
}