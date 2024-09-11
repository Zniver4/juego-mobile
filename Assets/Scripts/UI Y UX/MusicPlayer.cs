using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] musicClips; // Lista de clips de m�sica
    private AudioSource audioSource;
    private int currentClipIndex = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayNextClip();
    }

    void Update()
    {
        // Verifica si la m�sica ha terminado de reproducirse
        if (!audioSource.isPlaying)
        {
            PlayNextClip();
        }
    }

    void PlayNextClip()
    {
        if (musicClips.Length == 0)
            return;

        audioSource.clip = musicClips[currentClipIndex];
        audioSource.Play();

        // Incrementa el �ndice y reinicia si llega al final de la lista
        currentClipIndex = (currentClipIndex + 1) % musicClips.Length;
    }
}

