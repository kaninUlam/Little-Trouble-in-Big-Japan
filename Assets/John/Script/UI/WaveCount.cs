using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveCount : MonoBehaviour
{
    public Text WaveNum;
    public Spawner CurrentWave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WaveNum.GetComponent<UnityEngine.UI.Text>().text = CurrentWave.WaveCount.ToString();
    }
}
