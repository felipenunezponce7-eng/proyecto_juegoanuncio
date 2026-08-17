using TMPro;
using UnityEngine;

public class Textodebuuf : MonoBehaviour
{
    public TextMeshProUGUI texto;

    public int valor = 5;

    void Start()
    {
        texto.text = "-" + valor;
    }
}