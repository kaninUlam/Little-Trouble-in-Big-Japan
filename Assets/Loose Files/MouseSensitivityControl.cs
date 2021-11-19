using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSensitivityControl : MonoBehaviour
{
    public CameraMovement mouseSens;

    public void ChangeMouseSens(float amount)
    {
        mouseSens.GetComponent<CameraMovement>().ChangeMouseSensitivity(amount);

    }

}
