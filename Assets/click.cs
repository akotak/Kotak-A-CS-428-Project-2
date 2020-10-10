using System;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class click : MonoBehaviour
{

    public GameObject vbBtnObj;


    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("Interrupt");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);


    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        Debug.Log("Button pressed");

    

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

        Debug.Log("Button released");
      
    }
}
