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
        SFXData newSourceData = data;

        newSource.spatialBlend = 1;
        if (newSourceData.Type != 0)
        {
            newSource.playOnAwake = false;
        }

        newSource.Play();
        if(data.Looping == false)
        {
            Object.Destroy(sfxObject, data.SFX.length);
        }
        return newSource;
    }

}
