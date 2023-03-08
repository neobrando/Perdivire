using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BotonParaPulmon : MonoBehaviour
{
    //Variables para desaparecer y aparecer paneles
    public bool showMenu;
    public bool showP1;
    public bool showP2;
    public bool showP3;
    public bool showP4;
    public bool showP5;
    public bool showP6;

    //Variables Publicas para desaparecer botones
    [SerializeField] GameObject btn_P1;
    [SerializeField] GameObject btn_P2;
    [SerializeField] GameObject btn_P3;
    [SerializeField] GameObject btn_P4;
    [SerializeField] GameObject btn_P5;
    [SerializeField] GameObject btn_P6;



    void start()
    {
    }

    // Metodos para cambiar entre true/false los booleanos cada que presionas el btn correspondiente
    public void ButtonShowMenu()
    {
        if(!showMenu)
            showMenu = true;
        else if (showMenu)
            showMenu = false;
    }

    public void ButtonShowP1()
    {
        //Panel mostrado
        if(!showP1){
            showP1 = true;
            btn_P2.SetActive(false);
            btn_P3.SetActive(false);
            btn_P4.SetActive(false);
            btn_P5.SetActive(false);
            btn_P6.SetActive(false);
        }
        //Panel oculto
        else if (showP1){
            showP1 = false;
            btn_P2.SetActive(true);
            btn_P3.SetActive(true);
            btn_P4.SetActive(true);
            btn_P5.SetActive(true);
            btn_P6.SetActive(true);
        }
    }

    public void ButtonShowP2()
    {
        //Panel mostrado
        if(!showP2){
            btn_P2.transform.Translate(0f, 190.44058f, 0f); 
            showP2 = true;
            btn_P1.SetActive(false);
            btn_P3.SetActive(false);
            btn_P4.SetActive(false);
            btn_P5.SetActive(false);
            btn_P6.SetActive(false);
        }
        //Panel oculto
        else if (showP2){
            btn_P2.transform.Translate(0f, -190.44058f, 0f);
            showP2 = false;
            btn_P1.SetActive(true);
            btn_P3.SetActive(true);
            btn_P4.SetActive(true);
            btn_P5.SetActive(true);
            btn_P6.SetActive(true);
        }
    }
    
    public void ButtonShowP3()
    {
        //Panel mostrado
        if(!showP3){
            btn_P3.transform.Translate(0f, 450.44058f, 0f); 
            showP3 = true;
            btn_P1.SetActive(false);
            btn_P2.SetActive(false);
            btn_P4.SetActive(false);
            btn_P5.SetActive(false);
            btn_P6.SetActive(false);
        }
        //Panel oculto
        else if (showP3){
            btn_P3.transform.Translate(0f, -450.44058f, 0f);
            showP3 = false;
            btn_P1.SetActive(true);
            btn_P2.SetActive(true);
            btn_P4.SetActive(true);
            btn_P5.SetActive(true);
            btn_P6.SetActive(true);
        }
    }

    public void ButtonShowP4()
    {
        //Panel mostrado
        if(!showP4){
            btn_P4.transform.Translate(0f, 750.44058f, 0f); 
            showP4 = true;
            btn_P1.SetActive(false);
            btn_P2.SetActive(false);
            btn_P3.SetActive(false);
            btn_P5.SetActive(false);
            btn_P6.SetActive(false);
        }
        //Panel oculto
        else if (showP4){
            btn_P4.transform.Translate(0f, -750.44058f, 0f);
            showP4 = false;
            btn_P1.SetActive(true);
            btn_P2.SetActive(true);
            btn_P3.SetActive(true);
            btn_P5.SetActive(true);
            btn_P6.SetActive(true);
        }
    }

    public void ButtonShowP5()
    {
        //Panel mostrado
        if(!showP5){
            btn_P5.transform.Translate(0f, 1000.44058f, 0f); 
            showP5 = true;
            btn_P1.SetActive(false);
            btn_P2.SetActive(false);
            btn_P3.SetActive(false);
            btn_P4.SetActive(false);
            btn_P6.SetActive(false);
        }
        //Panel oculto
        else if (showP5){
            btn_P5.transform.Translate(0f, -1000.44058f, 0f);
            showP5 = false;
            btn_P1.SetActive(true);
            btn_P2.SetActive(true);
            btn_P3.SetActive(true);
            btn_P4.SetActive(true);
            btn_P6.SetActive(true);
        }
    }
    public void ButtonShowP6()
    {
        //Panel mostrado
        if(!showP6){
            btn_P6.transform.Translate(0f, 1000.44058f, 0f); 
            showP6 = true;
            btn_P1.SetActive(false);
            btn_P2.SetActive(false);
            btn_P3.SetActive(false);
            btn_P4.SetActive(false);
            btn_P5.SetActive(false);
        }
        //Panel oculto
        else if (showP6){
            btn_P6.transform.Translate(0f, -1000.44058f, 0f);
            showP6 = false;
            btn_P1.SetActive(true);
            btn_P2.SetActive(true);
            btn_P3.SetActive(true);
            btn_P4.SetActive(true);
            btn_P5.SetActive(true);
        }
    }
}
