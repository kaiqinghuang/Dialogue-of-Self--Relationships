using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class origin : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private Vector3 initialAnimatedPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Save the initial position and rotation
        initialPosition = transform.position;
        initialRotation = transform.rotation;

        // Add 90 degrees to the x rotation
        transform.rotation *= Quaternion.Euler(90, 0, 0);

        // Save the initial animated position
        initialAnimatedPosition = transform.position;
    }

    // LateUpdate is called after all Update methods
    void LateUpdate()
    {
        // Calculate the position change
        Vector3 positionChange = transform.position - initialAnimatedPosition;

        // Apply the position change to the initial position
        transform.position = initialPosition + positionChange;
    }
}