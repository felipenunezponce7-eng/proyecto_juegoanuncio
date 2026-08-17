using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaJugador : MonoBehaviour
{
    private TextMeshProUGUI texto;

    public int vidaactual;

    void Awake()
    {
        texto = GetComponentInChildren<TextMeshProUGUI>();
    }

    void Start()
    {
        vidaactual = 100;

        texto.text = "Vida: " + vidaactual;
    }
    private void Update()
    {
        if (vidaactual == 0)
        {
            SceneManager.LoadScene("Pantalla_Derrota");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "buff")
        {
            other.gameObject.SetActive(false);
        }
        else
        {
            other.gameObject.SetActive(false);

            vidaactual -= 10;

            texto.text = "Vida: " + vidaactual;
        }
            
    }
}