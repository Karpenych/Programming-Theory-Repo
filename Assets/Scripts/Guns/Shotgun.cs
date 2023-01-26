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
        ShootingInfo = "single shooting\n\t\t(5 bullets)";
        IsDropped = false;
        PositionOnDesk = transform.position;
        RotationOnDesk = transform.rotation;
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
        base.Shoot(new Vector3(direction.x - 0.2f, direction.y, direction.z));
        base.Shoot(new Vector3(direction.x - 0.1f, direction.y, direction.z));
        base.Shoot(direction);
        base.Shoot(new Vector3(direction.x + 0.1f, direction.y, direction.z));
        base.Shoot(new Vector3(direction.x + 0.2f, direction.y, direction.z));
    }
}
