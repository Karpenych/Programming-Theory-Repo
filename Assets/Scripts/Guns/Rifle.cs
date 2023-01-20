using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Gun
{
    private const float shootTimer = 0.1f;
    private bool isCanShoot = true;


    private void Start()
    {
        Damage = 10;
        ShootPower = 50;
        BulletAmount = 30;
        ShootingInfo = "automatic shooting";
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Shoot(transform.forward);
        }
    }

    protected override void Shoot(Vector3 direction)
    {
        if (isCanShoot)
        {
            base.Shoot(direction);
            isCanShoot = false;
            StartCoroutine(ShootTimer());
        }
    }

    IEnumerator ShootTimer()
    {
        yield return new WaitForSeconds(shootTimer);
        isCanShoot = true;
    }
}
