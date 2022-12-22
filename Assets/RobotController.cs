using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    // naming constraints do not change
    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;

    [SerializeField] private Transform SensorFR;
    [SerializeField] private Transform SensorL1;
    [SerializeField] private Transform SensorL2;
    [SerializeField] private Transform SensorL3;
    [SerializeField] private Transform SensorR1;
    [SerializeField] private Transform SensorR2;
    [SerializeField] private Transform SensorR3;
    [SerializeField] private Transform SensorOR;

    [SerializeField] private float maxSteeringAngle;
    [SerializeField] private float motorForce;
    [SerializeField] private float brakeForce;

    // Reference to the robot's rigidbody
    private Rigidbody robotRigidbody;

    // Speed of the robot
    public float speed = 10f;

    // Angular speed of the robot
    public float angularSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // Get the rigidbody component
        robotRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the input from the user
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement vector
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // Rotate the robot based on the angular speed
        transform.Rotate(Vector3.up, horizontalInput * angularSpeed * Time.deltaTime);

        // Move the robot
        robotRigidbody.MovePosition(transform.position + movement);
    }
}