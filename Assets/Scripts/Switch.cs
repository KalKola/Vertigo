using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public enum ResetType { Never, OnUse, Timed, Immediately }
    public ResetType resetType = ResetType.OnUse;
    public List<GameObject> Targets = new List<GameObject>();
    public string OnMessage;
    public string OffMessage;
    public bool isOn;

    public float ResetTime;
   // Animator myAnimator;

    // Use this for initialization
    void Start()
    {
        //myAnimator = GetComponent<Animator>();
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
        if (isOn && resetType != ResetType.Never && resetType != ResetType.Timed)
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

    public void TimedReset()
    {
        SetState(false);
    }


    // Update is called once per frame
    void SetState(bool on)
    {
        isOn = on;
        //myAnimator.SetBool("On", on);
        if (on)
        {
            if (Targets.Count > 0 && !string.IsNullOrEmpty(OnMessage))
            {
                Targets.ForEach(n => n.SendMessage(OnMessage));
            }
            if (resetType == ResetType.Immediately)
            {
                TurnOff();
            }
            else if (resetType == ResetType.Timed)
                Invoke("TimedReset", ResetTime);
        }
        else
        {
            if (Targets.Count > 0 && !string.IsNullOrEmpty(OffMessage))
            {
                Targets.ForEach(n => n.SendMessage(OffMessage));
            }
        }
    }
}