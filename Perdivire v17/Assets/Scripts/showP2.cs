using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showP2 : MonoBehaviour
{
    private Animator buttonAnim;
    private Boton boton;

    // Start is called before the first frame update
    void Start()
    {
        buttonAnim = GetComponent<Animator>();
        boton = GameObject.Find("Code").GetComponent<Boton>();
    }

    // Update is called once per frame
    void Update()
    {
        if(boton.showP2)
            buttonAnim.SetBool ("b_showP", true);
        if(!boton.showP2)
            buttonAnim.SetBool ("b_showP", false);
    }
}
