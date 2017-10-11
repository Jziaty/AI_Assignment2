using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;

    public Vector3 offset;
    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;

    public float pitch = 2f;

    public float panSpeed = 4.0f;

    private Vector3 mouseOrigin;
    private Vector3 pos;
    private Vector3 oldPos;
    private bool isPanning;
    private float currentZoom = 10f;
    private float currentYaw = 0f;

    private bool isRotating;    // Is the camera being rotated?

    private void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
    }


    private void LateUpdate()
    {
        if (!isRotating)
        {
            transform.position = target.position - offset * currentZoom;
            transform.LookAt(target.position + Vector3.up * pitch);

            transform.RotateAround(target.position, Vector3.up, currentYaw);
        }
        
    }
}
