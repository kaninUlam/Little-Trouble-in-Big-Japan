using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public CharacterMovement character;



    public void SpeedUpPerk()
    {
        character.GetComponent<CharacterMovement>();
        character.speed = character.speed * 2;
        character.runSpeed = character.runSpeed * 2;
        character.normalSpeed = character.normalSpeed * 2;
    }
    

}
