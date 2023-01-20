using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Info : MonoBehaviour
{
    [SerializeField] Gun gun;
    [SerializeField] GameObject InfoPanel;
    [SerializeField] TextMeshProUGUI bulletsAmountText;
    [SerializeField] TextMeshProUGUI damageAmountText;
    [SerializeField] TextMeshProUGUI headerText;
    [SerializeField] TextMeshProUGUI shootingText;

    public void ShowInfo()
    {
        headerText.text = gun.GetComponent<Gun>().GetType().ToString();
        bulletsAmountText.text += $" {gun.BulletAmount} bullets";
        damageAmountText.text += $" {gun.Damage} hp";
        shootingText.text += $" {gun.ShootingInfo}";
        
        InfoPanel.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ShowInfo();
        }
    }

}
