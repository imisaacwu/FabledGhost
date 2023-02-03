using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float speed = 12f;
    private const float g = -9.81f;
    private Vector3 v;
    private float groundDist = 0.4f;
    private bool grounded;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        controller.Move((transform.right*x + transform.forward*z)*speed*Time.deltaTime);
        grounded = Physics.CheckSphere(groundCheck.position,groundDist,groundMask);
        if(grounded&&v.y<0) { v.y = -2f; }
        v.y += g*Time.deltaTime;
        controller.Move(v*Time.deltaTime);
    }
}
