using UnityEngine;

public class PlayerDeath : MonoBehaviour {
    [HideInInspector]
    public int health;
    public int maxHealth;

    public void HealthPack() {
        health = maxHealth;
    }

    public void LoseHealth(int _amount) {
        health -= _amount;
        if (health <= 0) {
            Die();
        } else {
            FindObjectOfType<AudioManager>().Play("healthLoss");
        }
    }
    void Die() {
        Debug.Log("Player has died!");
        FindObjectOfType<AudioManager>().Play("die");
        // Play Dealth Animation
        // Restart Level
    }
}