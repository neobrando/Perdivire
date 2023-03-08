using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio : MonoBehaviour
{ 
 public GameObject p1;

  
  public void MostrarObjeto()
   {
    
       if (p1.activeSelf==false)

           p1.SetActive(true);
       else 
           p1.SetActive(false);
       }
}