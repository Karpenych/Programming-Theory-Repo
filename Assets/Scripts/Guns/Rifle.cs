using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Gun
{
    public Rifle Instance { get; private set; }
    private const float shootTimer = 0.1f;
    private bool isCanShoot = true;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Damage = 10;
        ShootPower = 50f;

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

    public override void ShowInfo()
    {
        throw new System.NotImplementedException();
    }

}
