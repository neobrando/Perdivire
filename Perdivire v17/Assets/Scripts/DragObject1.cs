using System.Collections;
using UnityEngine;


public class DragObject1 : MonoBehaviour {
 // Variables
 Vector3 dist;
 float posX;
 float posY;    


 // Function that detects when de 3D model is pressed
 void OnMouseDown(){
  dist = Camera.main.WorldToScreenPoint(transform.position);
  posX = Input.mousePosition.x - dist.x;
  posY = Input.mousePosition.y - dist.y;
  
 }

 // Function that moves the 3D object while being pressed
 void OnMouseDrag(){
  Vector3 curPos = 
   new Vector3(Input.mousePosition.x - posX, 
               Input.mousePosition.y - posY, dist.z);  
  
  Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
  transform.position = worldPos;
 }
}
