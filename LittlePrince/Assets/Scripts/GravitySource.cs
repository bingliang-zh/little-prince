using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySource : MonoBehaviour
{
    public float gravity = -10f;

    public void AttractInUpdate(Rigidbody body) {
        Vector3 gravityUp = body.position - transform.position; // not normalized

    }

    public void AttractInFixedUpdate(Rigidbody body) {
        Vector3 gravityUp = body.position - transform.position; // not normalized
        body.AddForce(gravityUp * gravity);

        Vector3 bodyUp = body.transform.up;
        Quaternion targetRotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;
        body.MoveRotation(Quaternion.Slerp(body.transform.rotation, targetRotation, 20f * Time.deltaTime));
    }
}
