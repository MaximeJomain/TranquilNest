using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButton : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOff() {
        transform.rotation = Quaternion.Euler(new Vector3(-25, 0, 0));
    }

    public void TurnOn()
    {
        transform.rotation = Quaternion.Euler(new Vector3(25, 0, 0));
    }
}
