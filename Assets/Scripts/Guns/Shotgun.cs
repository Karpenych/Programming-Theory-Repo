using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Gun
{
    public Shotgun Instance { get; private set; }


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Damage = 15;
        ShootPower = 100f;

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot(transform.forward);
        }
    }

    public override void ShowInfo()
    {
        throw new System.NotImplementedException();
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
