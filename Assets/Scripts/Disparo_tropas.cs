using UnityEngine;

public class Disparo_tropas : MonoBehaviour
{
    

    public float fireRate = 0.5f;

    public float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireRate)
        {
            timer = 0;

            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bala =
    Balapool.Instance.ObtenerBala();

        bala.transform.position =
            transform.position;

        bala.transform.rotation =
            Quaternion.Euler(0, 0, 0);

        bala.SetActive(true);
    }
}