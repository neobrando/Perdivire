using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio3 : MonoBehaviour
{ 
 public GameObject p3;

  
  public void MostrarObjeto()
   {
    
       if (p3.activeSelf==false)

           p3.SetActive(true);
       else 
           p3.SetActive(false);
       }
}