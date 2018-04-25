using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public bool isOpen;
    Collider2D selfCollidor;
    public int requiredSwitch;
    //Animator myAnimator; 
    private int switch_amount;

	// Use this for initialization
	void Start () {
        selfCollidor = GetComponent<Collider2D>();
        //myAnimator = GetComponent<Animator>();
	}
	
    public void Open()
    {
        switch_amount++;
        if (!isOpen && switch_amount == requiredSwitch)
        {
            SetState(true);
        }
    }

    public void Close()
    {
        switch_amount--;
        if (isOpen)
        {
            SetState(false);
        }

    }

    public void Toggle()
    {
        if (isOpen)
        {
            Close();
        }
        else
        {
            Open();
        }
    }

    void SetState(bool open)
    {
        isOpen = open;
        //myAnimator.SetBool("Open", open);
        selfCollidor.isTrigger = open;
    }
}
