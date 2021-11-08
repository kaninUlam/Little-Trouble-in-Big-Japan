using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerkRayCast : MonoBehaviour
{
    public LayerMask layersToCheck;

    bool fireRatePerk = false;
    bool speedUpPerk = false;

    public Text fireRateText;
    public Text SpeedUpText;

    // Start is called before the first frame update
    void Start()
    {
        fireRatePerk = false;
        speedUpPerk = false;

        fireRateText.gameObject.SetActive(false);
        SpeedUpText.gameObject.SetActive(false);
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
                    
                    GameObject fireRateUpPerk = hit.collider.gameObject;
                    fireRateUpPerk.GetComponent<FireRateUp>().FireRateUpPerk();
                    fireRatePerk = true;
                    
                }
                if (hit.collider.tag == "SpeedUpPerk" && speedUpPerk == false)
                {
                    GameObject SpeedUpPerk = hit.collider.gameObject;
                    SpeedUpPerk.GetComponent<SpeedUp>().SpeedUpPerk();
                    speedUpPerk = true;
                }
            }
        }

        if (Physics.Raycast(transform.position, transform.forward, out hit, 50, layersToCheck))
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

        }


    }
}
