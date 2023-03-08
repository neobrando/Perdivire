using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class unityBaseDatos : MonoBehaviour
{
    public string parteCuerpo = "cabeza";//nombre de la parte del cuerpo
    public string textValue;
    public Text textElement;

    [ContextMenu("Leer Simple")]//el código corre cuando se le da a "leer simple" en opciones del script

    public void LeerSimple(){//funcion leer simple
        StartCoroutine(CorrutinaLeerSimple());//empieza corrutina
    }

    private IEnumerator CorrutinaLeerSimple(){//corrutina
        UnityWebRequest web = UnityWebRequest.Get("http://localhost/conexion.php?parte=" + parteCuerpo);//accede a la base de datos a la parte del cuerpo solicitada
        yield return web.SendWebRequest();// esperar al resultado de internet
        if(web.downloadHandler.text == "mal"){//si ubo un error mal...
            Debug.Log("Error");//da un error en la consola
        }else{//si no...

            Debug.Log(web.downloadHandler.text);//se imprimira toda la informacion de la parte del cuerpo en la consola de unity
            textValue=web.downloadHandler.text;
            textElement.text=textValue;

        }
    }
}
