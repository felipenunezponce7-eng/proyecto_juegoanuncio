using UnityEngine;

public class Disparo_Player : MonoBehaviour
{
 
    public Transform firePoint;

    public float fireRate = 0.1f;

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
            firePoint.position;

        bala.transform.rotation =
            firePoint.rotation;

        bala.SetActive(true);
    }
}