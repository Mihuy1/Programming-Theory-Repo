using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Camera playerCamera;

    private Rigidbody playerRb;

    [SerializeField]
    private int horsePower = 10;
    [SerializeField]
    private float rotationSpeed = 45f;

    private float verticalInput;
    private float horizontalInput;

    private Vector3 offset = new Vector3(0, 8, -10);


    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    public void LateUpdate()
    {
        playerCamera.transform.position = gameObject.transform.position + offset;
    }

    public void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);

    }
}
