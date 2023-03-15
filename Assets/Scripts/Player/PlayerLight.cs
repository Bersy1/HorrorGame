using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{
    [SerializeField]
    private GameObject flashLight;
    [SerializeField]
    private GameObject lighterLight;



    public void FlashlightState()
    {
        Light flashlightstate = flashLight.GetComponent<Light>();

        flashlightstate.enabled = !flashlightstate.enabled;
    }
    public void LighterState()
    {
        Light lighterstate = lighterLight.GetComponent<Light>();

        lighterstate.enabled = !lighterstate.enabled;
    }

}
