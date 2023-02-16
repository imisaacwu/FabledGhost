using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Transform orientation;
    [SerializeField] float sensX, sensY;
    private float xRot, yRot;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        yRot += Input.GetAxisRaw("Mouse X")*Time.deltaTime*sensX;
        xRot -= Input.GetAxisRaw("Mouse Y")*Time.deltaTime*sensY;
        xRot = Mathf.Clamp(xRot,-90f,90f);
        transform.rotation = Quaternion.Euler(xRot,yRot,0);
        orientation.rotation = Quaternion.Euler(0,yRot,0);
    }

    // private void FixedUpdate()
    // {
    //     transform.Translate(hMove*moveSpd*Time.deltaTime,0,vMove*moveSpd*Time.deltaTime);
    //     transform.Rotate(-vLook*lookSpd*Time.deltaTime,hLook*lookSpd*Time.deltaTime,0);
    //     // rb.position.Set(rb.position.x, camHeight, rb.position.y);
    // }
}
