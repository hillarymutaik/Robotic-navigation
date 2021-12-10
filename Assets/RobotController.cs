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

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
}