using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSounds : MonoBehaviour
{
    private AudioSource bgAudio;
    private AudioSource grabSource;
    public AudioClip windAudio;
    public AudioClip grabAudio;

    void Start()
    {
        bgAudio = GetComponent<AudioSource>();
        grabSource = GetComponent<AudioSource>();

        grabSource.clip = grabAudio;

        bgAudio.clip = windAudio;
        bgAudio.loop = true;
        bgAudio.volume = 0.85f;
        bgAudio.Play();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "Hand")
        {
            grabSource.Play();
        }
    }
}
