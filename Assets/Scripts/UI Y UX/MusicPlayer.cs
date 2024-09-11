using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] musicClips; // Lista de clips de música
    private AudioSource audioSource;
    private int currentClipIndex = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayNextClip();
    }

    void Update()
    {
        // Verifica si la música ha terminado de reproducirse
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

        // Incrementa el índice y reinicia si llega al final de la lista
        currentClipIndex = (currentClipIndex + 1) % musicClips.Length;
    }
}

