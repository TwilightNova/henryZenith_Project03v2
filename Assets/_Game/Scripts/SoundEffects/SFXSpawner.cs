using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SFXSpawner : MonoBehaviour
{
    private AudioSource source;
    [SerializeField] private SFXData data;

    private void Awake()
    {
        source.spatialBlend = 1;
        if(data.Type != 0)
        {
            source.playOnAwake = false;
        }
    }
}
