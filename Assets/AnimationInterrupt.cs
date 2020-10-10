using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class AnimationInterrupt : MonoBehaviour
{
    public Animator animator;
    public GameObject vbBtnObj;

    AudioSource voiceline;
    //bool buttonPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("Interrupt");
        animator.GetComponent<Animator>();
        voiceline = GetComponent<AudioSource>();
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        Debug.Log("Button pressed");

        //buttonPressed = true;
        //animator.Play("stand");
        animator.Play("sit idle");
        //voiceline.Play();
        /*if (buttonPressed && animator.GetCurrentAnimatorStateInfo(0).IsName("sit idle"))
        {
            voiceline.Play();
        }*/

        //animator.SetBool("buttonPressed", buttonPressed);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //buttonPressed = false;
        voiceline.Play();
        animator.Play("stand");
        //animator.Play("sit idle");
        Debug.Log("Button released");

    }
    
    // Update is called once per frame
    /*void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            buttonPressed = true;
        }
        else
        {
            buttonPressed = false;
        }
        if(buttonPressed && animator.GetCurrentAnimatorStateInfo(0).IsName("sit idle"))
        {

            voiceline.Play();
        } 

        animator.SetBool("buttonPressed", buttonPressed);
    }
    */
}
