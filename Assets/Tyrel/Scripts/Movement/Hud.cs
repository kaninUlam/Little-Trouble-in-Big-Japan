using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{

    public Text healthText;
    public Text shotgunAmmoText;
    public Text sniperAmmoText;


    public Sniper sniperAmmo;
    public Shotgun shotgunAmmo;
    public Health playerHealth;

    public Image crossair;
    public Image sniperAmmoImg;
    public Image shotgunAmmoImg;

    // Start is called before the first frame update
    void Start()
    {

        sniperAmmo.GetComponent<Sniper>();
        shotgunAmmo.GetComponent<Shotgun>();
        playerHealth.GetComponent<Health>();

        healthText.gameObject.SetActive(true);
        crossair.gameObject.SetActive(true);
        sniperAmmoText.gameObject.SetActive(true);
        sniperAmmoImg.gameObject.SetActive(true);
        shotgunAmmoText.gameObject.SetActive(true);
        shotgunAmmoImg.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = playerHealth.maxHealthPoints + "/" + playerHealth.currentHealthPoints;
        sniperAmmoText.text = sniperAmmo.ammo + "";
        shotgunAmmoText.text = shotgunAmmo.ammo + "";


    }





}
