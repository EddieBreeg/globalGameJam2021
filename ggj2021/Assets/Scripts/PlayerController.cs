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
        Open = 1,
        None = 2
    }

    public enum SubPowerups{
        Repeat = 0,
        Timeout = 1,
        None = 2
    }

    public bool[] subpowerupsInventory;
    public bool[] powerupsInventory;

    public GameObject[] powerupsVisu;

    public GameObject[] subpowerupsVisu;

    Interactable focus = null;
    public GameObject interactMessage;

    bool isUiOn = false;

    int memoriesRecovered = 0;

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

    public void uiOn(){
        isUiOn = true;
        Cursor.lockState = CursorLockMode.None;
    }
    
    public void uiOff(){
        isUiOn = false;
        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log("Ui off: " + isUiOn);
        Debug.Log("Ui off: " + Cursor.lockState);
    }

    public Interactable getFocus(){
        return focus;
    }

    // Start is called before the first frame update
    void Start()
    {
        powerupsInventory = new bool[Globally.nbPowerups];
        subpowerupsInventory = new bool[Globally.nbSubpowerups];
        myRb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    public bool hasPowerup(Powerups pu){
        return powerupsInventory[(int)pu];
    }

    public void removePowerup(Powerups pu){
        powerupsInventory[(int)pu] = false;
        powerupsVisu[(int)pu].SetActive(false);
    }

    public void addPowerup(Powerups pu){
        powerupsInventory[(int)pu] = true;
        powerupsVisu[(int)pu].SetActive(true);
    }

    public bool hasSubPowerup(SubPowerups spu){
        return subpowerupsInventory[(int)spu];
    }

    public void removeSubPowerup(SubPowerups spu){
        subpowerupsInventory[(int)spu] = false;
        subpowerupsVisu[(int)spu].SetActive(false);
    }

    public void addSubPowerup(SubPowerups spu){
        subpowerupsInventory[(int)spu] = true;
        subpowerupsVisu[(int)spu].SetActive(true);
    }

    public void gatherMemory(){
        memoriesRecovered+=1;
    }

    public int getMemories(){
        return memoriesRecovered;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isUiOn){
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
}
