using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveCount : MonoBehaviour
{
    public Text WaveNum;
    public Spawner CurrentWave;
    // Update is called once per frame
    void Update()
    {
        WaveNum.GetComponent<UnityEngine.UI.Text>().text = "Wave: " + CurrentWave.WaveCount.ToString();
    }
}
