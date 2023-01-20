using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    private void Start()
    {
        Damage = 5;
        ShootPower = 10f;
        BulletAmount = 8;
        ShootingInfo = "single shooting";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot(transform.forward);
        }
    }
}
