using System.Collections;
using UnityEngine;

public class Vida_Enemigo : MonoBehaviour
{

    public int vidainicial = 10;
    private int vidaactual;
    public GameObject efectoMuerte;
    Renderer[] renderers;

    void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();
        vidaactual = vidainicial;
    }
    private void OnEnable()
    {
        vidaactual = vidainicial;
        
    }

    public void RecibirDaño(int daño)
    {
        vidaactual -= daño;

        StartCoroutine(Flash());

        if (vidaactual <= 0)
        {
            StartCoroutine(Morir());
        }
    }

    IEnumerator Flash()
    {
        foreach (Renderer r in renderers)
        {
            foreach (Material m in r.materials)
            {
                m.EnableKeyword("_EMISSION");
                m.SetColor("_EmissionColor", Color.white * 3f);
            }
        }

        yield return new WaitForSeconds(0.03f);

        foreach (Renderer r in renderers)
        {
            foreach (Material m in r.materials)
            {
                m.SetColor("_EmissionColor", Color.black);
            }
        }
    }
    IEnumerator Morir()
    {
        Instantiate(
            efectoMuerte,
            transform.position,
            Quaternion.identity
        );

        float tiempo = 0.1f;

        Vector3 escalaInicial =
            transform.localScale;

        while (tiempo > 0)
        {
            tiempo -= Time.deltaTime;

            transform.localScale =
                escalaInicial *
                (tiempo / 0.1f);

            yield return null;
        }

        gameObject.SetActive(false);
        transform.localScale = escalaInicial;
    }
}