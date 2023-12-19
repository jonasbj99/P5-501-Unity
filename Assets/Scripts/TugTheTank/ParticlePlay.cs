using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlay : MonoBehaviour
{
    public ParticleSystem dirtParticle1;
    public ParticleSystem dirtParticle2;

    void Start()
    {
        dirtParticle1.Play();
        dirtParticle2.Play();
    }

    void Update()
    {
        
    }
}
