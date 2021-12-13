using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float _sensitivity;
    [SerializeField] private Transform _body;

    private float _xRotation;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        var mouseX = Input.GetAxis("Mouse X") * _sensitivity * Time.deltaTime;
        var mouseY = Input.GetAxis("Mouse Y") * _sensitivity * Time.deltaTime;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);


        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        _body.Rotate(Vector3.up * mouseX);

        if (Input.GetKeyDown(KeyCode.Escape))
            Cursor.visible = true;
    }
}