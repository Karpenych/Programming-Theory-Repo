using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{    
    [SerializeField] GameObject bulletPrefab;
    
    public float Damage { get; protected set; }
    public float ShootPower { get; protected set; }
    public float BulletAmount { get; protected set; }
    public string ShootingInfo { get; protected set; }

    
    protected virtual void Shoot(Vector3 direction)
    {
        {
            GameObject tmp = Instantiate(bulletPrefab, transform.position, transform.rotation);
            tmp.GetComponent<Rigidbody>().velocity = direction.normalized * ShootPower;
        }
    }
}
