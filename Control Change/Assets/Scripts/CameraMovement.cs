using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public float moveSpeed;

    void Update() {
        transform.Translate(Vector2.right * moveSpeed);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            other.GetComponent<PlayerDeath>().LoseHealth(99999);
        }
    }
}