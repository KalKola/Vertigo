using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureSwitch : Switch {

    //Can be used to determine how many pressure switches are needed to do something
    int numColliding = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        numColliding++;
        if(collision.gameObject.tag == "grabable")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        }
        TurnOn();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        numColliding--;
        if(numColliding == 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            TurnOff();
        }
    }
}
