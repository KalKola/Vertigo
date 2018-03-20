using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public bool isOpen;
    Collider2D myCollidor;
    Animator myAnimator;    

	// Use this for initialization
	void Start () {
        myCollidor = GetComponent<Collider2D>();
        myAnimator = GetComponent<Animator>();
	}
	
    public void Open()
    {
        if (!isOpen)
        {
            SetState(true);
        }
    }

    public void Close()
    {
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
        myAnimator.SetBool("Open", open);
        myCollidor.isTrigger = open;
    }
}
