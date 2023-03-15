using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLights : MonoBehaviour
{
    public void ChangeToGreen()
    {
        gameObject.GetComponent<Light>().color = Color.green;
    }
}
