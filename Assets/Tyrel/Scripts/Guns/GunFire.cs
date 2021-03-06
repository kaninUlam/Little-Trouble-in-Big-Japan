using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public GunRayCast gunRayCast;

    public GameObject Projectile;
    public Transform gunEnd;

    public float spread = 5;

    float assualtRange = 100;
    float shotgunRange = 50f;
    float sniperRange = 500;

    public Movement movement;
    public Camera Camera;

    void Start()
    {
        movement.GetComponent<Movement>();
    }

    public virtual void FireProjectile()
    {
        gunRayCast.weaponRange = shotgunRange;

        Ray ray = Camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;

        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
        {
            targetPoint = hit.point;
        }

        else
        {
            targetPoint = ray.GetPoint(1000);
        }

        for (int i = 10; i >= 0; i--)
        {
            GameObject Shells = Instantiate(Projectile, gunEnd.transform.position, transform.rotation);
            Shells.transform.Rotate(Random.Range(spread, -spread), Random.Range(spread, -spread), 0);

            Destroy(Shells, 0.1f);



        }
        gunRayCast.raycastShoot();
    }

    public void FireAssualtProjectile()
    {
        gunRayCast.weaponRange = assualtRange;

        Ray ray = Camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;

        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
            targetPoint = hit.point;
        else
            targetPoint = ray.GetPoint(1000);

        gunRayCast.raycastShoot();
        GameObject bullets = Instantiate(Projectile, gunEnd.transform.position, transform.rotation);
        bullets.GetComponent<Rigidbody>().velocity = (targetPoint - gunEnd.transform.position).normalized * movement.Speed;
        Destroy(bullets, .5f);
    }

    public void FireSniperProjectile()
    {
        gunRayCast.weaponRange = sniperRange;

        Ray ray = Camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;

        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
            targetPoint = hit.point;
        else
            targetPoint = ray.GetPoint(1000);

        gunRayCast.raycastShoot();
        GameObject bullets = Instantiate(Projectile, gunEnd.transform.position, transform.rotation);
        bullets.GetComponent<Rigidbody>().velocity = (targetPoint - gunEnd.transform.position).normalized * movement.Speed;
        Destroy(bullets, 1);
    }
}
