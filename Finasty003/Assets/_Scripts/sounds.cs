using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class sounds
{
    public string name;
    public AudioClip clip;

    [Range(0f,1f)]
    public float Audio;

    [HideInInspector]
    public AudioSource source;
}
