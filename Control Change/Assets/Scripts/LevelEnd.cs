using UnityEngine;

public class LevelEnd : MonoBehaviour {
    public LevelLoader lLoader;

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Collider touched");
        if (other.CompareTag("Player")) {
            lLoader.LoadNextLevel();
        }
    }
}