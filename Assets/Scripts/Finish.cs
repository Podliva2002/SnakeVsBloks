using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject Win;
    private AudioSource FinishSound;
    ParticleSystem Won;

    void Start()
    {
        Won = GetComponent<ParticleSystem>();
        FinishSound = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        FinishSound.Play();
        Win.SetActive(true);
        Won.Play();
    }
}
