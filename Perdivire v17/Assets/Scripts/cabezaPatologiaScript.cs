using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class cabezaPatologiaScript : MonoBehaviour
{
    public string parteCuerpo="cabezaPatologia";
    public string parteCuerpo1="cabezaPatologia2";//nombre de la parte del cuerpo
    public Text textElement;
    public string valor;
    public string cabezaPatalogiaParte1;
    void Start()
    {
        StartCoroutine(CorrutinaLeerSimple1());
        StartCoroutine(CorrutinaLeerSimple());
    }

    private IEnumerator CorrutinaLeerSimple1(){//corrutina
        UnityWebRequest web2 = UnityWebRequest.Get("https://perdivire.000webhostapp.com/BaseDatos.php?parte=" + parteCuerpo);//accede a la base de datos a la parte del cuerpo solicitada
        yield return web2.SendWebRequest();// esperar al resultado de internet

        if(web2.downloadHandler.text == "mal"){//si ubo un error da lo imprime
            Debug.Log("Error");//da un error en la consola
        }else{
            cabezaPatalogiaParte1=web2.downloadHandler.text;
        }
    }
    private IEnumerator CorrutinaLeerSimple(){//corrutina
        UnityWebRequest web = UnityWebRequest.Get("https://perdivire.000webhostapp.com/BaseDatos.php?parte=" + parteCuerpo1);//accede a la base de datos a la parte del cuerpo solicitada
        yield return web.SendWebRequest();// esperar al resultado de internet

        if(web.downloadHandler.text == "mal"){//si ubo un error da lo imprime
            Debug.Log("Error");//da un error en la consola
        }else{//si no...

            textElement.text=cabezaPatalogiaParte1 + web.downloadHandler.text;//Imprimir la info en el text field
        }
    }
}