using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public GameObject Target;
    public string OnMessage;
    public string OffMessage;
    public bool isOn;
    Animator myAnimator;

    // Use this for initialization
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void TurnOn()
    {
        if (!isOn)
        {
            SetState(true);
        }
    }

    public void TurnOff()
    {
        if (isOn)
        {
            SetState(false);
        }
    }

    public void Toggle()
    {
        if (isOn)
        {
            TurnOff();
        }
        else
        {
            TurnOn();
        }
    }
    // Update is called once per frame
    void SetState(bool on)
    {
        isOn = on;
        myAnimator.SetBool("On", on);
        if (on)
        {
            if (Target != null && !string.IsNullOrEmpty(OnMessage))
            {
                Target.SendMessage(OnMessage);
            }
        }
        else
        {
            if (Target != null && !string.IsNullOrEmpty(OffMessage))
            {
                Target.SendMessage(OffMessage);
            }
        }
    }
}