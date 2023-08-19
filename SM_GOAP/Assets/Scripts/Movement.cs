using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    Vector3 moveDir;
    Rigidbody rigidbody;
    public float speed = 10f;
    public Transform orientation;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody= GetComponent<Rigidbody>();
        rigidbody.freezeRotation= true;
        rigidbody.drag = 1f;
    }       
    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        moveDir = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rigidbody.AddForce(moveDir.normalized * speed, ForceMode.Force);
    }
}
