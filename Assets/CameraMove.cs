using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [Header("Ruch kamery")]
    public float moveSpeed = 20f;

    [Header("Zoom kamery")]
    public float zoomSpeed = 5f;
    public float minZoom = 4f;
    public float maxZoom = 10f;

    public Camera cam;
    public float cameraSize;
   

    [Header("Granice mapy")]
    public float minX = -10f ;
    public float maxX = 10f ;
    public float minY = -5f ;
    public float maxY = 5f;


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

        Vector3 move = new Vector3(moveX, moveY, 0f).normalized;
        transform.position += move * moveSpeed * Time.deltaTime;
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
        float clampedX = Mathf.Clamp(transform.position.x, minX * 5 / cameraSize, maxX * 5 / cameraSize);
        float clampedY = Mathf.Clamp(transform.position.y, minY * 5 / cameraSize, maxY * 5 / cameraSize);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}
