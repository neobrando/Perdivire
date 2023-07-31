using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


// Class to get the info of the pathologies in the DB
public class Enfermedad : MonoBehaviour
{
    public string parteCuerpo="";//Name of the body part to get all the pathologies info
    public Text textElement;
    public string valor;
    
    void Start()
    {
        StartCoroutine(CorrutinaLeerSimple());
    }

    private IEnumerator CorrutinaLeerSimple(){//corrutine for the start() method
        UnityWebRequest web = UnityWebRequest.Get("https://perdivire.000webhostapp.com/BaseDatos.php?parte=" + parteCuerpo);// Access the body part info in the DB
        yield return web.SendWebRequest();// Wait the response for the DB

        // ERROR connecting to the DB
        if(web.downloadHandler.text == "mal"){
            Debug.Log("Error");
        }else{ // The DB was accesed correctly
            textElement.text=web.downloadHandler.text;// Show the info
        }
    }
}
