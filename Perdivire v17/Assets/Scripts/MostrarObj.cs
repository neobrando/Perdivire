using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class that switch the object use to True/False
public class MostrarObj : MonoBehaviour
{
    public GameObject objeto;

  public void MostrarObjeto()
  {

    if (objeto.activeSelf==false)
        objeto.SetActive(true);
    else
        objeto.SetActive(false);
  }


  
}
