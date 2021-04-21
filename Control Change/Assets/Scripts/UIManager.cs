using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour {
    public PlayerMovement player;
    public TextMeshProUGUI leftText;
    public TextMeshProUGUI rightText;
    public TextMeshProUGUI jumpText;

    void Update() {
        leftText.text = player.moveLeft.ToString();
        rightText.text = player.moveRight.ToString();
        jumpText.text = player.jump.ToString();
    }
}