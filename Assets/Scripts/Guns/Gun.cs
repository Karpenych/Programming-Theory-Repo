using TMPro;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{    
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject bulletSpawner;
    
    public float Damage { get; protected set; }
    protected float BulletAmount { get; set; }
    protected float BulletsLeft { get; set; }
    public bool IsDropped { get; set; }
    protected float ShootPower { get; set; }
    protected string ShootingInfo { get; set; }
    protected Vector3 PositionOnDesk { get; set; }
    protected Quaternion RotationOnDesk { get; set; }
    [SerializeField] GameObject InfoPanel;
    [SerializeField] TextMeshProUGUI bulletsAmountText;
    [SerializeField] TextMeshProUGUI damageAmountText;
    [SerializeField] TextMeshProUGUI headerText;
    [SerializeField] TextMeshProUGUI shootingText;


    protected virtual void Shoot(Vector3 direction)
    {
        if (IsDropped && BulletsLeft > 0) 
        {
            --BulletsLeft;
            GameObject tmp = Instantiate(bulletPrefab, bulletSpawner.transform.position, transform.rotation);
            tmp.GetComponent<Rigidbody>().velocity = direction.normalized * ShootPower;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }

    protected void Reload()
    {
        BulletsLeft = BulletAmount;
    }

    public void ShowInfo()
    {
        headerText.text = GetComponent<Gun>().GetType().ToString();
        bulletsAmountText.text = $"Clip: {BulletAmount} bullets";
        damageAmountText.text = $"Damage: {Damage} hp";
        shootingText.text = $"Shooting: {ShootingInfo}";

        InfoPanel.SetActive(true);
    }

    public void HideInfo() => InfoPanel.SetActive(false);

    public void PutOnDesk()
    {
        gameObject.transform.parent = null;
        gameObject.transform.position = PositionOnDesk;
        gameObject.transform.rotation = RotationOnDesk;
        IsDropped = false;
    }

    private void OnGUI()
    {
        if (IsDropped)
        {
            GUIStyle gs = new();
            gs.normal.textColor = new Color(10, 10, 10, 0.6f);
            gs.fontSize = 25;
            GUI.Label(new Rect(Camera.main.pixelWidth - 200, Camera.main.pixelHeight - 150, 30, 30), "Press R to reload", gs); // Clip
            gs.fontSize = 50;
            GUI.Label(new Rect(Camera.main.pixelWidth - 140, Camera.main.pixelHeight - 100, 30, 30), $"{BulletsLeft}/{BulletAmount}", gs); // Clip
        }
    }
}
