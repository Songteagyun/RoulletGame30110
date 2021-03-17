using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotspeed = 0.0f;

    void Update()

    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotspeed = 0.0f;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            this.rotspeed = 20.0f;
        }
        transform.Rotate(0, 0, this.rotspeed);
        this.rotspeed = this.rotspeed * 0.987f;
    }
   
}
