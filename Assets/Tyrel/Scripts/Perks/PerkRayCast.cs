﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerkRayCast : MonoBehaviour
{
    public LayerMask layersToCheck;

    bool fireRatePerk = false;
    bool speedPerk = false;
    bool gunDamagePerk = false;
    bool healthPerk = false;

    public Text fireRateText;
    public Text SpeedUpText;
    public Text gunDamageUpText;
    public Text healthUpText;

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

    }

    // Update is called once per frame
    void Update()
    {
        

        RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.E))
        {
            

            if (Physics.Raycast(transform.position, transform.forward, out hit, 10, layersToCheck))
            {
                if (hit.collider.tag == "FireRatePerk" && fireRatePerk == false)
                {
                    
                    fireRateImg.gameObject.SetActive(true);
                    GameObject fireRateUpPerk = hit.collider.gameObject;
                    fireRateUpPerk.GetComponent<FireRateUp>().FireRateUpPerk();
                    fireRatePerk = true;
                    
                }
                if (hit.collider.tag == "SpeedUpPerk" && speedPerk == false)
                {
                    speedUpImg.gameObject.SetActive(true);
                    GameObject SpeedUpPerk = hit.collider.gameObject;
                    SpeedUpPerk.GetComponent<SpeedUp>().SpeedUpPerk();
                    speedPerk = true;
                }
                if (hit.collider.tag == "GunDamageUpPerk" && gunDamagePerk == false)
                {
                    gunDamageUpImg.gameObject.SetActive(true);
                    GameObject gunDamageUpPerk = hit.collider.gameObject;
                    gunDamageUpPerk.GetComponent<DamageUp>().DamageUpPerk();
                    gunDamagePerk = true;
                }
                if(hit.collider.tag == "HealthUpPerk")
                {
                    healthUpImg.gameObject.SetActive(true);
                    GameObject healthUpPerk = hit.collider.gameObject;
                    healthUpPerk.GetComponent<HealthUp>().HealthUpPerk();
                    healthPerk = true;
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


        }


    }
}
