using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Camera playerCamera;

    private Rigidbody playerRb;

    protected int horsePower;

    // ENCAPSULATION
    public float rotationSpeed { get; private set; }

    private float verticalInput;
    private float horizontalInput;

    private Vector3 offset = new Vector3(0, 8, -10);


    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        rotationSpeed = 45;
    }

    public void LateUpdate()
    {
        CameraPositioning();
    }

    public void FixedUpdate()
    {
        Debug.Log(horsePower);
        VehicleControl();
    }

    // ABSTRACTION

    public virtual void VehicleControl()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);
    }

    void CameraPositioning()
    {
        playerCamera.transform.position = gameObject.transform.position + offset;
    }
}
