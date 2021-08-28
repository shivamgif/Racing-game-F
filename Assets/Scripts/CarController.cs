﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CarController : MonoBehaviour
{
    public float speed = 10;
    public float speedRotation = 0;
    public float brakes;

    public float currentSpeed;
    public float moveAside;

    private float horizontalInput;
    private float verticalInput;

    private bool isBreaking;

    [SerializeField] private float brakeForce = 0f;

    private float t;

    public Color red = Color.red;
    public Color blue = Color.blue;
    public Color green = Color.green;
    public Color yellow = Color.yellow;
    public Color white = Color.white;
    public GameObject cube;


    private float SteerAngle;
    public StateManager stateManager;

    [SerializeField] private float maxSteeringAngle = 110f;
    [SerializeField] private float minSteeringAngle = 40f;
    public void Awake()
    {
        if(StateManager.Color1== true)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        if (StateManager.Color2 == true)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (StateManager.Color3 == true)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (StateManager.Color4 == true)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        if (StateManager.Color5 == true)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
    }

    private void Update()
    {
       // transform.eulerAngles = new Vector3(0, HandleSteering(),0);

    }
    private void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
    }

    private void HandleMotor()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        //moveAside = speed * horizontalInput;
        //oveAside *= Time.deltaTime;
        //transform.Translate(moveAside, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = Mathf.Lerp(speed, 0, t);
            
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * speed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * speed, Space.World);
        }

        t += 0.2f *Time.fixedDeltaTime;
       if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            speed += 2;
        }
    }

    private float HandleSteering()
    {
        SteerAngle = maxSteeringAngle * horizontalInput;
        return SteerAngle;
    }


}
