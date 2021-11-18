using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{

    public Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        animator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100f))
            {
                

                if(hit.transform.gameObject.tag == "Start")
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

                if(hit.transform.gameObject.tag == "Options")
                {
                    Debug.Log("Options");
                    animator.SetBool("Options", true);
                    
                }
                else
                {
                    animator.SetBool("Options", false);
                }

                if(hit.transform.gameObject.tag == "Back")
                {
                    Debug.Log("back");
                    animator.SetBool("BackToMenu", true);
                }
                else
                {
                    animator.SetBool("BackToMenu", false);
                }
            }

        }

    }

    IEnumerator LoadStart()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(1);
    }




}
