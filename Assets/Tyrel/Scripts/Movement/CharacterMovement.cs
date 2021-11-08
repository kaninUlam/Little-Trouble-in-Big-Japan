using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterMovement : MonoBehaviour
{

    public GameObject fpsCamera = null;

    public CharacterController controller;

    public float speed = 12;
    public float runSpeed = 20;
    public float normalSpeed = 12;
    public float gravity = -9.8f;
    

    bool sprinting = false;

    AudioSource aSource = null;

    bool IsMoveing;
    
    float walkStepLength = 0.75f;
    float runStepLength = 0.25f;

    public AudioClip[] aClips = null;

    public Vector3 velocity;

    public float timerMax = 1f;
    public float timer = 0;



    public Transform GroundCheck;
    public float GroundDistance = 0.4f;
    public LayerMask GroundMask;

    public bool isGrounded;
    public float jumpHeight = 10f;

    // Start is called before the first frame update
    void Start()
    {
        

        aSource = GetComponent<AudioSource>();

        timer = runStepLength;
        
    }

    // Update is called once per frame
    void Update()
    {
        fpsCamera.GetComponentInChildren<Camera>().fieldOfView = 80;

        isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        } 

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (!isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        

        controller.Move(velocity * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }


        if (Input.GetKey(KeyCode.LeftShift))
        {

                sprinting = true;
                
                PlayRunning();
                
                fpsCamera.GetComponentInChildren<Camera>().fieldOfView = Mathf.Lerp(80, 85, 1);
                speed = runSpeed;
  
        }
        else
        {
            
            sprinting = false;
        }

        

        if (move != Vector3.zero && sprinting == false)
        {
            IsMoveing = true;
        }
        else
        {
            IsMoveing = false;
        }



        if (IsMoveing == true)
        {
            
            PlayWalking();
        }
        
        if (sprinting == false)
        {
            speed = normalSpeed;
            

        }


        

    }

    void PlayWalking()
    {
        int aIndex = Random.Range(0, aClips.Length);

        
        
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            
            timer = walkStepLength;
            aSource.clip = aClips[aIndex];

            PlayFootSteps(aClips[aIndex]);
        }
        

        
    }


    void PlayRunning()
    {
        int aIndex = Random.Range(0, aClips.Length);

        if (sprinting == true && timer < 0)
        {
            timer = runStepLength;
        }

        timer -= Time.deltaTime;
        if (timer < 0)
        {
            
            timer = runStepLength;
            aSource.clip = aClips[aIndex];

            PlayFootSteps(aClips[aIndex]);
        }
    }
    
    void PlayFootSteps(AudioClip clip)
    {
        
        aSource.PlayOneShot(clip);
        
    }


    


    

}
