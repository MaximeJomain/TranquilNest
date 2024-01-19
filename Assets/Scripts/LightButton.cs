using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButton : MonoBehaviour
{

    public void TurnOff() {
        transform.rotation = Quaternion.Euler(new Vector3(-25, 0, 0));
    }

    public void TurnOn()
    {
        transform.rotation = Quaternion.Euler(new Vector3(25, 0, 0));
    }
}
