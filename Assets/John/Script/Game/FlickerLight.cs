using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public float minflickerspeed;
    public float maxflickerspeed;
    public float timer;
    public Light lights;
    private void Start()
    {
        timer = Random.Range(minflickerspeed, maxflickerspeed);
    }
    // Update is called once per frame
    void Update()
    {
        if(timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            flicker();
        }
    }
    void flicker()
    {
        lights.enabled = !lights.enabled;
        timer = Random.Range(minflickerspeed, maxflickerspeed);
    }
}
