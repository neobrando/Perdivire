using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio2 : MonoBehaviour
{ 
 public GameObject p2;

  
  public void MostrarObjeto()
   {
    
       if (p2.activeSelf==false)

           p2.SetActive(true);
       else 
           p2.SetActive(false);
       }
}