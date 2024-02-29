using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;
    public GameObject sfxSwitch;
    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitch, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
