using UnityEngine;
using System.Collections.Generic;

public class ChangeControls : MonoBehaviour {
    public PlayerMovement player;
    public KeyCode[] keys;
    public List<KeyCode> keysLeft = new List<KeyCode>();

    void SetKeys() {
        keysLeft = new List<KeyCode>();
        keys[0] = KeyCode.A;
        keys[1] = KeyCode.B;
        keys[2] = KeyCode.C;
        keys[3] = KeyCode.D;
        keys[4] = KeyCode.E;
        keys[5] = KeyCode.F;
        keys[6] = KeyCode.G;
        keys[7] = KeyCode.H;
        keys[8] = KeyCode.I;
        keys[9] = KeyCode.J;
        keys[10] = KeyCode.K;
        keys[11] = KeyCode.L;
        keys[12] = KeyCode.M;
        keys[13] = KeyCode.N;
        keys[14] = KeyCode.O;
        keys[15] = KeyCode.P;
        keys[16] = KeyCode.Q;
        keys[17] = KeyCode.R;
        keys[18] = KeyCode.S;
        keys[19] = KeyCode.T;
        keys[20] = KeyCode.U;
        keys[21] = KeyCode.V;
        keys[22] = KeyCode.W;
        keys[23] = KeyCode.X;
        keys[24] = KeyCode.Y;
        keys[25] = KeyCode.Z;
        for (int i = 0; i < 26; i++) {
            keysLeft.Add(keys[i]);
        }
    }
    void Awake() {
        SetKeys();
    }
    public void NewKeys() {
        int r = Random.Range(0, 25);
        player.moveLeft = keysLeft[r];
        keysLeft.RemoveAt(r);
        r = Random.Range(0, keysLeft.Count);
        player.moveRight = keysLeft[r];
        keysLeft.RemoveAt(r);
        r = Random.Range(0, keysLeft.Count);
        player.jump = keysLeft[r];
        keysLeft.RemoveAt(r);
        SetKeys();
    }
}