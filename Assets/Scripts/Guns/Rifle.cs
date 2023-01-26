using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Gun
{
    private const float shootTimer = 0.1f;
    private bool isCanShootNow = true;


    private void Start()
    {
        Damage = 10;
        ShootPower = 100;
        BulletAmount = 30;
        ShootingInfo = "automatic shooting";
        IsDropped = false;
        PositionOnDesk = transform.position;
        RotationOnDesk = transform.rotation;
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
        if (isCanShootNow)
        {
            base.Shoot(direction);
            isCanShootNow = false;
            StartCoroutine(ShootTimer());
        }
    }

    IEnumerator ShootTimer()
    {
        yield return new WaitForSeconds(shootTimer);
        isCanShootNow = true;
    }
}
