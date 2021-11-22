using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{

    public Animator animator;

    public AudioClip[] aClips = null;
    public AudioSource aSource = null;

    bool OnHover = false;
    bool hover = true;

    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 1;
        OnHover = true;
        animator.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            {


                if (hit.transform.gameObject.tag == "Start")
                {
                    Debug.Log("Start");
                    animator.SetBool("StartPressed", true);
                    StartCoroutine(LoadStart());
                }
                else
                {
                    animator.SetBool("StartPressed", false);
                }

                if (hit.transform.gameObject.tag == "Exit")
                {
                    Application.Quit();
                }

                if (hit.transform.gameObject.tag == "Options")
                {
                    Debug.Log("Options");
                    animator.SetBool("Options", true);

                }


                if (hit.transform.gameObject.tag == "Back")
                {
                    Debug.Log("back");
                    animator.SetBool("BackToMenu", true);
                    animator.SetBool("Options", false);
                    StartCoroutine(BackToIdle());
                }

            }

        }



        RaycastHit hit2;

        Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray2, out hit2, 100f))
        {
            if (hit2.transform.gameObject.tag == "Start" && OnHover == true)
            {
                
                MenuSound(0);
                OnHover = false;
            }
            
                

            if (hit2.transform.gameObject.tag == "Options" && OnHover == true)
            {
                MenuSound(1);
                OnHover = false;
            }
            

            if (hit2.transform.gameObject.tag == "Exit" && OnHover == true)
            {
                MenuSound(2);
                OnHover = false;
            }
            

            if (hit2.transform.gameObject.tag == "Back" && OnHover == true)
            {
                MenuSound(3);
                OnHover = false;
            }
            
        }
    }

    IEnumerator OnHoverTrue()
    {
        yield return new WaitForSeconds(1);
        OnHover = true;
    }

    void MenuSound(int amount)
    {


        aSource.clip = aClips[amount];

        PlayMenuSound(aClips[amount]);
    }

    void PlayMenuSound(AudioClip clip)
    {
        aSource.PlayOneShot(clip);
    }


    IEnumerator LoadStart()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(1);
    }

    IEnumerator BackToIdle()
    {
        yield return new WaitForSeconds(2);
        animator.SetBool("BackToMenu", false);
    }




}
