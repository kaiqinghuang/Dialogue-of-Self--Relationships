using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick : MonoBehaviour
{
    public Transform rightHand; // The transform of the mixamorig:RightHand bone

    // Update is called once per frame
    void Update()
    {
        // Set the position of the stick to the position of the right hand
        transform.position = rightHand.position;

        // Set the rotation of the stick to the rotation of the right hand
        transform.rotation = rightHand.rotation;
    }
}