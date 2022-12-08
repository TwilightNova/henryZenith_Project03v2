using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXSpawner : MonoBehaviour
{
    [Tooltip("Pass in a Scriptable Object.")]
    [SerializeField] private SFXData data;

    public AudioSource PlayClip2D()
    {
        GameObject sfxObject = new GameObject("2DSoundEffect");
        AudioSource newSource = sfxObject.AddComponent<AudioSource>();

        newSource.volume = data.Volume;
        newSource.pitch = data.Pitch;
        newSource.minDistance = data.MinDistance;
        newSource.maxDistance = data.MaxDistance;

        newSource.Play();
        if(data.Looping == false)
        {
            Object.Destroy(sfxObject, data.SFX.length);
        }
        return newSource;
    }

}