using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
 
 // Rotate the 3D model automatically every frame
 void Update () {
  transform.Rotate(0,20*Time.deltaTime,0);
 }
}
