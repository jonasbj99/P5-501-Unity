using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlay : MonoBehaviour
{
    public ParticleSystem dirtParticle1;
    public ParticleSystem dirtParticle2;
    // Start is called before the first frame update
    void Start()
    {
        dirtParticle1.Play();
        dirtParticle2.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
