using UnityEngine;


public class CarControl : MonoBehaviour {
    public float moveSpeed = 15;

    private Vector3 moveDir;

    void Update() {
        moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        Debug.Log(moveDir);
    }

    void FixedUpdate() {
        Rigidbody body = GetComponent<Rigidbody>();
        body.MovePosition(body.position + transform.TransformDirection(moveDir) * moveSpeed);
    }
}
