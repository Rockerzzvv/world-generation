﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform PlayerBody;
    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * MouseX);
    }
}
