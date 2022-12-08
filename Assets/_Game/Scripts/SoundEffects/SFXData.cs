using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SFXData_", menuName = "SoundData/SFX")]
[RequireComponent(typeof(AudioSource))]
public class SFXData : ScriptableObject
{
    private AudioSource source;

    [SerializeField] private AudioClip sFX;

    [SerializeField] private SFXType type = 0;

    [Header("Audio Control")]

    [Tooltip("Adjust the sound's volume, from muted to maximum volume.")]
    [Range(0, 1)]
    [SerializeField] private float _volume;

    [Tooltip("Adjust the sound's pitch. This will speed up or slow down the audio.")]
    [Range(-3, 3)]
    [SerializeField] private float _pitch;

    [Tooltip("Will this sound effect loop after playing? Or will it end after playing once?")]
    [SerializeField] private bool isLooping;

    [Tooltip("Adjust the minimum distance. At this distance from the sound effect, the audio will be at its loudest.")]
    [SerializeField] private float minDistance;
    [Tooltip("Adjust the maximum distance. Outside of this distance, the audio cannot be heard.")]
    [SerializeField] private float maxDistance;

    [Header("Position Control")]
    [Tooltip("Pass in an object that the sound effect will spawn from. See 'Spawn Position' for sound effects that are not spawned on objects.")]
    [SerializeField] private Transform spawnObject;
    [Tooltip("Pass in a transform value for the sound effect to spawn at. See 'Spawn Object' for sound effects that spawn when triggered by an object.")]
    [SerializeField] private Vector3 spawnPosition;

    #region Get Functions
    public SFXType Type => type;
    public bool Looping => isLooping;
    #endregion
}
