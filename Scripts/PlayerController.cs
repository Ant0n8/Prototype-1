using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 80.0f;
    private float horiztontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get horizontal and vertical input
        horiztontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move vehicle forward or backwards based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Move vehicle right or left based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horiztontalInput);
    }
}