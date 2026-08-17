using UnityEngine;

public class Debuff : MonoBehaviour
{

    public int debufodaño = 5;
    [Header("Tropas a eliminar")]
    public int tropasADestruir = 5;

    private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        Master.Instance.dañoJugador -= debufodaño;

            Army_Aliados.Instance.DestruirTropas(
                   tropasADestruir
               );

            Destroy(gameObject);
            Master.Instance.dañoJugador =
    Mathf.Max(
        1,
        Master.Instance.dañoJugador - 1
    );
        }
}
}
