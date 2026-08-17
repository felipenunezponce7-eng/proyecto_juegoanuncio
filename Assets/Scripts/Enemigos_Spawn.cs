using UnityEngine;

public class Enemigos_Spawn : MonoBehaviour
{
    public float Ratio_Aparicion = 1f;

    public int enemigosPorSpawn = 1;
    public float tiempoPartida;

    float timerDificultad;

    void Start()
    {
        InvokeRepeating(
            nameof(SpawnEnemybase),
            1f,
            Ratio_Aparicion
        );
    }

    void Update()
    {
        tiempoPartida += Time.deltaTime;
        timerDificultad += Time.deltaTime;

        if (timerDificultad >= 5f && enemigosPorSpawn <= 6 && tiempoPartida <= 40f)
        {
            timerDificultad = 0f;
            enemigosPorSpawn++;
        }
        if (enemigosPorSpawn >= 6)
        {
            if (timerDificultad >= 5f)
            {
                if (Ratio_Aparicion >= 0.2)
                {
                    Ratio_Aparicion = Ratio_Aparicion / 2;
                }
                timerDificultad = 0f;
            }
        }
        if (tiempoPartida >= 40f && tiempoPartida <= 80f)
        {
            enemigosPorSpawn = 4;
            Ratio_Aparicion = 1;
        }
        if (tiempoPartida >= 76f)
        {
            enemigosPorSpawn = 2;
            
        }
    }

    void SpawnEnemybase()
    {
        GameObject enemigo;

        if (tiempoPartida >= 80f)
        {
      
            enemigo = Enemypooljefe.Instance.ObtenerEnemigo();
            Ratio_Aparicion = 140;
            gameObject.SetActive(false);
        }
        else if (tiempoPartida >= 40f)
        {
           
            enemigo = EnemyPool2.Instance.ObtenerEnemigo();
        }
        else
        {
            enemigo = EnemyPoll.Instance.ObtenerEnemigo();
        }

        enemigo.transform.position =
            new Vector3(
                Random.Range(-4f, 4f),
                1,
                transform.position.z
            );
        if (enemigo.transform.rotation.y != 180)
        {
            enemigo.transform.rotation = Quaternion.Euler( 0, 180, 0 );
        }
        

        enemigo.SetActive(true);
    }

}