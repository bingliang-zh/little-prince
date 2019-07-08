using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform player;

    void LateUpdate() {
        Vector3 newPosition = player.position * 2;
        transform.SetPositionAndRotation(newPosition, player.rotation);
        
    }
}
