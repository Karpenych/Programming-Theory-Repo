using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    protected float Damage { get; set; }
    protected float ShootPower { get; set; }

    protected virtual void Shoot(Vector3 direction)
    {
        {
            GameObject tmp = Instantiate(bulletPrefab, transform.position, transform.rotation);
            tmp.GetComponent<Rigidbody>().velocity = direction.normalized * ShootPower;
        }
    }

    public abstract void ShowInfo();

}
