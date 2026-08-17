using TMPro;
using UnityEngine;

public class Textobuff : MonoBehaviour
{
    public TextMeshPro texto;

    public int valor = 10;

    void Start()
    {
        texto.text = "+" + valor;
    }
}