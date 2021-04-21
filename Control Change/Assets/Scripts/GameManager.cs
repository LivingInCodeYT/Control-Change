using UnityEngine;

public class GameManager : MonoBehaviour {
    public ChangeControls controls;
    public float changeEvery;
    private float _changeEvery;

    void Awake() {
        _changeEvery = changeEvery;
    }
    void Update() {
        if (_changeEvery <= 0f) {
            _changeEvery = changeEvery;
            controls.NewKeys();
        } else {
            _changeEvery -= Time.deltaTime;
        }
    }
}