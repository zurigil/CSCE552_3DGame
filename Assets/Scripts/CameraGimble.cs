using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGimble : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 turn;
    public float sensitivity = 0.5f;
    public Vector3 deltaMove;
    public float lookSpeed = 0.5f;
    Ray ray;
    Camera cam;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //ray = (transform.position, transform.forward);

        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        //transform.Rotate(Vector3.up, lookSpeed * Time.deltaTime * Input.GetAxis("Mouse X"), Space.World);
        //cam.transform.Rotate(Vector(Vector3.right, lookSpeed * Time.deltaTime * Input.GetAxis("Mouse Y"), Space.World));
    }
}
