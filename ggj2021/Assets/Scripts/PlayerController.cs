using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody myRb;

    private float vertical;
    private float horizontal;

    Vector3 front;
    Vector3 right;

    public Camera myCamera;

    public float mouseSensitivity;

    public enum powerups{
        Activate = 0,
        Open = 1
    }

    public bool[] powerups_inventory;

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        front = transform.forward;
        right = transform.right; //left/right axis

        myRb.MovePosition(transform.position + front * vertical * speed * Time.deltaTime + right * horizontal * speed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        transform.Rotate(Vector3.up * mouseX);
    }
}
