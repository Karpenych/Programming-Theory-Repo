using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    public Pistol Instance { get; private set; }
    

    private void Awake()
    {
        Instance = this; 
    }

    private void Start()
    {
        Damage = 5;
        ShootPower = 10f;
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

    

    
}
