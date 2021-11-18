using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDurationOnGround : MonoBehaviour
{
    public float _DurationOnGround;

    
    public void Update()
    {
        _DurationOnGround -= Time.deltaTime;
        if(_DurationOnGround <= 0)
        {
            _itemExpires();
        }
    }
    public void _itemExpires()
    {
        Destroy(gameObject);
    }
}
