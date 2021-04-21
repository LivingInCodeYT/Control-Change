using UnityEngine;

[System.Serializable]
public class Sound {
    public string name;
    public AudioClip clip;
    [HideInInspector]
    public AudioSource source;
    [Range(0f, 10f)]
    public float volume = 1f;
    [Range(0f, 10f)]
    public float pitch = 1f;
    public bool loop;
}