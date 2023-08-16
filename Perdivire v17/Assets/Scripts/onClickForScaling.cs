using System.Collections;
using UnityEngine;


public class onClickForScaling : MonoBehaviour {
 void OnMouseDown() {
  CSharpscaling.ScaleTransform = this.transform;
 }
} 