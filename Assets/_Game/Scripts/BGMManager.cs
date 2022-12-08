using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BGMManager : MonoBehaviour
{
    public static BGMManager Instance;
    private AudioSource audioSource;

    [SerializeField] private AudioClip clip;

    [Header("Audio Control")]
    [Range(0, 1)]
    [SerializeField] private float _volume;
    [Range(-3, 3)]
    [SerializeField] private float _pitch;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
        }
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        if (clip != null)
            Instance.PlaySong(clip);
    }

    public void PlaySong(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.volume = _volume;
        audioSource.pitch = _pitch;
        audioSource.loop = true;
        audioSource.Play();
    }
}
