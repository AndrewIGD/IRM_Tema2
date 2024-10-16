using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseFinish : MonoBehaviour
{
    [SerializeField] private ParticleSystem _confetti;
    [SerializeField] private AudioSource _confettiSfx;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            _confetti.Play();
            _confettiSfx.Play();
        }
    }
}
