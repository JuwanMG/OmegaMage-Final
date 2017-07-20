using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick : MonoBehaviour {
    private Vector3 startPos;
    private Transform thisTransform;
    private MeshRenderer mr;
    public bool isButton;
    public bool leftJoystick;
    public string buttonName;

	// Use this for initialization
	void Start () {
        thisTransform = transform;
        startPos = new Vector3(5,5,0);
        mr = thisTransform.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isButton)
        {
            mr.enabled = Input.GetButton(buttonName);
        }else
        {
            if (leftJoystick)
            {
                Vector3 inputDirection = Vector3.zero;
                inputDirection.x = Input.GetAxis("LeftStickHorizontal");
                inputDirection.y = Input.GetAxis("LeftStickVertical");
                thisTransform.position = startPos + inputDirection;
            } else
            {
                Vector3 inputDirection = Vector3.zero;
                inputDirection.x = Input.GetAxis("RightStickHorizontal");
                inputDirection.y = Input.GetAxis("RightStickVertical");
                thisTransform.position = startPos + inputDirection;
            }
        }
	}
}
