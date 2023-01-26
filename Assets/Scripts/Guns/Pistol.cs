using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    private void Start()
    {
        Damage = 5;
        ShootPower = 100;
        BulletAmount = 8;
        ShootingInfo = "single shooting";
        IsDropped = false;
        PositionOnDesk = transform.position;
        RotationOnDesk= transform.rotation;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot(transform.forward);
        }
    }
}
