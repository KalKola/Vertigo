using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureSwitch : Switch {

    int numColliding = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        numColliding++;
        TurnOn();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        numColliding--;
        if(numColliding == 0)
        {
            TurnOff();
        }
    }
}
