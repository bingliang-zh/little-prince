using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityObject : MonoBehaviour
{
    public GravitySource gravitySource;

    void Start()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        if (rigidBody)
        {
            rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
            rigidBody.useGravity = false;
        }
    }

    void FixedUpdate()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        gravitySource.AttractInFixedUpdate(rigidBody);
    }
}
