using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform player;
    public Transform planet;

    void LateUpdate() {
        transform.position = player.position * 2;
        transform.LookAt(planet, player.forward);
    }
}
