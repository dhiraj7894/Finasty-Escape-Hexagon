using UnityEngine.Audio;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void setVolume(float volume) {
        audioMixer.SetFloat("volume", volume);
    }
}
