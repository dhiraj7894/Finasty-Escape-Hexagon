using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class audioManager : MonoBehaviour
{

    public AudioClip audioClip;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = audioClip;
        source.playOnAwake = false;
    }

    public void playSound()
    {
        source.PlayOneShot(audioClip);
    }
}
