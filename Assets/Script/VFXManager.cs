using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxAudioSource;
    public GameObject vfxSwitch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlayVFXSwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSwitch, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
