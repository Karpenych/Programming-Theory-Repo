using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Gun
{
    private void Start()
    {
        Damage = 15;
        ShootPower = 100f;
        BulletAmount = 30;
        ShootingInfo = "single shooting (5 bullets)";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot(transform.forward);
        }
    }

    protected override void Shoot(Vector3 direction)
    {
        base.Shoot(new Vector3(-0.2f, 0f, 1f));
        base.Shoot(new Vector3(-0.1f, 0f, 1f));
        base.Shoot(direction);
        base.Shoot(new Vector3(0.1f, 0f, 1f));
        base.Shoot(new Vector3(0.2f, 0f, 1f));
    }
}
