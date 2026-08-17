using UnityEngine;

public class Master : MonoBehaviour
{
    public static Master Instance;

    public int dañoJugador = 1;

    private void Awake()
    {
        Instance = this;
    }

}