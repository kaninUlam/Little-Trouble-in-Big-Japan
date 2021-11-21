using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerkRayCast : MonoBehaviour
{
    public LayerMask layersToCheck;

    
    public DifferentPointSystem scoreSystem;

    bool fireRatePerk = false;
    bool speedPerk = false;
    bool gunDamagePerk = false;
    bool healthPerk = false;

    public Text fireRateText;
    public Text SpeedUpText;
    public Text gunDamageUpText;
    public Text healthUpText;
    public Text WinText;
    public Text LoreText;

    public Image fireRateImg;
    public Image speedUpImg;
    public Image gunDamageUpImg;
    public Image healthUpImg;

    // Start is called before the first frame update
    void Start()
    {
        fireRatePerk = false;
        speedPerk = false;
        gunDamagePerk = false;
        healthPerk = false;

        fireRateText.gameObject.SetActive(false);
        SpeedUpText.gameObject.SetActive(false);
        gunDamageUpText.gameObject.SetActive(false);
        healthUpText.gameObject.SetActive(false);
        healthUpImg.gameObject.SetActive(false);
        gunDamageUpImg.gameObject.SetActive(false);
        speedUpImg.gameObject.SetActive(false);
        fireRateImg.gameObject.SetActive(false);
        WinText.gameObject.SetActive(false);
        LoreText.gameObject.SetActive(false);

        scoreSystem.GetComponent<DifferentPointSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        

        RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.E))
        {
            

            if (Physics.Raycast(transform.position, transform.forward, out hit, 20, layersToCheck))
            {
                if (hit.collider.tag == "FireRatePerk" && fireRatePerk == false && scoreSystem._PlayerScore >= 1000)
                {
                    Debug.Log("fireRateIncreased");
                    fireRateImg.gameObject.SetActive(true);
                    GameObject fireRateUpPerk = hit.collider.gameObject;
                    fireRateUpPerk.GetComponent<FireRateUp>().FireRateUpPerk();
                    fireRatePerk = true;
                    scoreSystem._PlayerScore -= 1000;
                }
                if (hit.collider.tag == "SpeedUpPerk" && speedPerk == false && scoreSystem._PlayerScore >= 1000)
                {
                    speedUpImg.gameObject.SetActive(true);
                    GameObject SpeedUpPerk = hit.collider.gameObject;
                    SpeedUpPerk.GetComponent<SpeedUp>().SpeedUpPerk();
                    speedPerk = true;
                    scoreSystem._PlayerScore -= 1000;
                }
                if (hit.collider.tag == "GunDamageUpPerk" && gunDamagePerk == false && scoreSystem._PlayerScore >= 1000)
                {
                    gunDamageUpImg.gameObject.SetActive(true);
                    GameObject gunDamageUpPerk = hit.collider.gameObject;
                    gunDamageUpPerk.GetComponent<DamageUp>().DamageUpPerk();
                    gunDamagePerk = true;
                    scoreSystem._PlayerScore -= 1000;
                }
                if(hit.collider.tag == "HealthUpPerk" && healthPerk == false && scoreSystem._PlayerScore >= 1000)
                {
                    healthUpImg.gameObject.SetActive(true);
                    GameObject healthUpPerk = hit.collider.gameObject;
                    healthUpPerk.GetComponent<HealthUp>().HealthUpPerk();
                    healthPerk = true;
                    scoreSystem._PlayerScore -= 1000;
                }

                if(hit.collider.tag == "Lore")
                {
                    Time.timeScale = 0;

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        Time.timeScale = 1;
                    }
                }



            }
        }

        if (Physics.Raycast(transform.position, transform.forward, out hit, 20, layersToCheck))
        {

            if (hit.collider.tag == "FireRatePerk")
            {
                
                fireRateText.gameObject.SetActive(true);
            }
            else
            {
                
                fireRateText.gameObject.SetActive(false);
            }

            if (hit.collider.tag == "SpeedUpPerk")
            {
                
                SpeedUpText.gameObject.SetActive(true);
            }
            else
            {
                SpeedUpText.gameObject.SetActive(false);
            }

            if(hit.collider.tag == "GunDamageUpPerk")
            {
                
                gunDamageUpText.gameObject.SetActive(true);
            }
            else
            {
                gunDamageUpText.gameObject.SetActive(false);
            }

            if(hit.collider.tag == "HealthUpPerk")
            {
                
                healthUpText.gameObject.SetActive(true);
            }
            else
            {
                healthUpText.gameObject.SetActive(false);
            }

            if (hit.collider.tag == "Win")
                WinText.gameObject.SetActive(true);
            else
                WinText.gameObject.SetActive(false);

            if (hit.collider.tag == "Lore")
                LoreText.gameObject.SetActive(true);
            else
                LoreText.gameObject.SetActive(false);

        }


    }
}
