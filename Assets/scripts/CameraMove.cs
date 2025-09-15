using UnityEngine;
using System;

public class CameraMove : MonoBehaviour
{
    [Header("Ruch kamery")]
    public float moveSpeed = 4f;

    [Header("Zoom kamery")]
    public float zoomSpeed = 5f;
    public float minZoom = 8f;
    public float maxZoom = 20f;

    public Camera cam;
    public float cameraSize;
   

    [Header("Granice mapy")]
    public float minX = -83f ;
    public float maxX = 83f ;
    public float minY = -55f ;
    public float maxY = 55f;


    void Start()
    {
        cam = GetComponent<Camera>();
        if (cam == null)
            Debug.LogError("Ten skrypt musi byæ na obiekcie z komponentem Camera!");
        cameraSize = cam.orthographicSize;
    }

    void Update()
    {
        HandleMovement();
        HandleZoom();
        ClampPosition();
    }

    void HandleMovement()
    {
        float moveX = 0f;
        float moveY = 0f;
        
        if (Input.GetKey(KeyCode.W)) moveY += 1f;
        if (Input.GetKey(KeyCode.S)) moveY -= 1f;
        if (Input.GetKey(KeyCode.A)) moveX -= 1f;
        if (Input.GetKey(KeyCode.D)) moveX += 1f;

        float CamSizeMultiplier = (float)cam.orthographicSize;
        Vector3 move = new Vector3(moveX, moveY, 0f).normalized;
        transform.position += move * moveSpeed * Time.deltaTime * CamSizeMultiplier;

    }

    void HandleZoom()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0f)
        {
            cam.orthographicSize -= scroll * zoomSpeed;
            cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minZoom, maxZoom);

            cameraSize = cam.orthographicSize;
        }
    }

    void ClampPosition()
    {
        float clampedX = Mathf.Clamp(transform.position.x, minX * 4/cameraSize, maxX * 4/cameraSize);
        float clampedY = Mathf.Clamp(transform.position.y, minY * 4/cameraSize, maxY * 4/cameraSize);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}
