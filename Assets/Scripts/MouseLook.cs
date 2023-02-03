using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    [SerializeField] float mouseSens = 100f;
    [SerializeField] Transform playerObj;
    private float xRot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*mouseSens*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*mouseSens*Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        playerObj.Rotate(Vector3.up*mouseX);
    }
}
