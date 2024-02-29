using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
  public KeyCode input;
  public Color color;
	
	// menyimpan angka target position saat ditekan dan dilepas
  private float targetPressed;
  private float targetRelease;

  private HingeJoint hinge;

  private void Start()
  {
    hinge = GetComponent<HingeJoint>();
	
		// saat Start, kita set kedua target tersebut
    targetPressed = hinge.limits.max;
    targetRelease = hinge.limits.min;

    GetComponent<Renderer>().material.color = color;
  }

  private void Update()
  {
    ReadInput();
  }

  private void ReadInput()
  {
    JointSpring jointSpring = hinge.spring;

    if (Input.GetKey(input))
    {
			//disini kita ganti menjadi mengubah target position nya
      jointSpring.targetPosition = targetPressed;
    }
    else
    {
      jointSpring.targetPosition = targetRelease;
    }

    hinge.spring = jointSpring;
  }
}