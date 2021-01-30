using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50f;

    private Rigidbody myRb;

    private float vertical;
    private float horizontal;

    Vector3 front;
    Vector3 right;

    public Camera myCamera;

    public float mouseSensitivity = 50f;

    private float xRotation = 0f;

    public enum Powerups{
        Activate = 0,
        Open = 1
    }

    public bool[] powerupsInventory;

    Interactable focus = null;
    public GameObject interactMessage;

    //interactions management

    public void setFocus(Interactable newFocus){
        focus = newFocus;
        if (newFocus == null){
            interactMessage.SetActive(false);
        } else{
            interactMessage.SetActive(true);
        }
    }

    public void focusInteract(){
        focus.interact(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    public bool hasPowerup(Powerups pu){
        return powerupsInventory[(int)pu];
    }

    public void removePowerup(Powerups pu){
        powerupsInventory[(int)pu] = false;
    }

    public void addPowerup(Powerups pu){
        Debug.Log(powerupsInventory);
        powerupsInventory[(int)pu] = true;
    }

    // Update is called once per frame
    void Update()
    {
        // move
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        front = transform.forward;
        right = transform.right; //left/right axis

        myRb.MovePosition(transform.position + front * vertical * speed * Time.deltaTime + right * horizontal * speed * Time.deltaTime);

        // turn around
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        transform.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        myCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        if (Input.GetButtonDown("Fire1")) // interragir
        {   
            if (focus != null){
                focusInteract();
            }
            /*Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //if we hit
            if (Physics.Raycast(ray, out hit, 100f))
            {
                PUPickup interac = hit.collider.GetComponent<PUPickup>();
                if (interac != null)
                {
                    
                }
            }*/
        }
    }
}
