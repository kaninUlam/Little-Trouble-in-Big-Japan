using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    [SerializeField]
    private GameObject[] itemList;
    private int itemNum;
    private int randNum;
    private Transform Epos;

    private void Start()
    {
        Epos = GetComponent<Transform>();
        Debug.Log(itemList);
    }

    public void itemDrop()
    {
        randNum = Random.Range(0, 101);
        Debug.Log("Random Number is " + randNum);

        if (randNum >= 90)
        {
            itemNum = 3;
            Instantiate(itemList[itemNum], Epos.position, Quaternion.identity);
        }
        else if (randNum > 70 && randNum < 90)
        {
            itemNum = 2;
            Instantiate(itemList[itemNum], Epos.position, Quaternion.identity);
        }
        else if (randNum > 40 && randNum < 70)
        {
            itemNum = 1;
            Instantiate(itemList[itemNum], Epos.position, Quaternion.identity);
        }
    }
}