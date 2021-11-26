using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMovement : MonoBehaviour
{

    public float speed = 10;
    public float time = 1;
    float minimum;
    float maximum;

    // Start is called before the first frame update
    void Start()
    {
        minimum = transform.localPosition.x;
        maximum = 1000;
        StartCoroutine(UISlide()); 
    }

    

    IEnumerator UISlide()
    {
        
        yield return new WaitForSeconds(time);

        transform.localPosition = new Vector3(Mathf.Lerp(minimum, maximum, 2), transform.localPosition.y, 0);
    }
}
