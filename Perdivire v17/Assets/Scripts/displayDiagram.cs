using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayDiagram : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;
    private Sprite oldSprite; // Declare oldSprite here

    // Start is called before the first frame update
    private bool flag = false;

    void Start()
    {
        oldSprite = original.sprite; // Initialize oldSprite in the Start method
    }

    // Update is called once per frame
    void Update()
    {
        // Your Update code here
    }

    public void NewImage()
    {
        flag = !flag;

        if (flag)
        {
            original.sprite = newSprite;
        }
        else
        {
            original.sprite = oldSprite;
        }
    }
}

