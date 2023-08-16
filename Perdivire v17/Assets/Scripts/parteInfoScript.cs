using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;


public class parteInfoScript : MonoBehaviour
{
    public string parteCuerpo;//nombre de la parte del cuerpo
    public TMP_Text txt;
    public string valor;

    
    void Start()
    {
        StartCoroutine(CorrutinaLeerSimple());
    }

    private IEnumerator CorrutinaLeerSimple(){//corrutina
        UnityWebRequest web = UnityWebRequest.Get("https://perdivire.000webhostapp.com/BaseDatos.php?parte=" + parteCuerpo);//accede a la base de datos a la parte del cuerpo solicitada
        yield return web.SendWebRequest();// esperar al resultado de internet

        if(web.downloadHandler.text == "mal"){//si ubo un error da lo imprime
            Debug.Log("Error");//da un error en la consola
        }else{//si no...
            txt.text=web.downloadHandler.text;//Imprimir la info en el text field
        }
    }
}