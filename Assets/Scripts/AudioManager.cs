using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _explosionClip;
    [SerializeField] private AudioClip _moveBodyClip;
    [SerializeField] private AudioClip _fallingClip;
    [SerializeField] private AudioClip _gruntClip;
    [SerializeField] private AudioClip _hospitalMachinesClip;

    public void PlayMoveBody()
    {
        _audioSource.PlayOneShot(_moveBodyClip);
    }

    public void PlayFalling()
    {
        _audioSource.PlayOneShot(_fallingClip);
    }

    public void PlayGrunt()
    {
        _audioSource.PlayOneShot(_gruntClip);
    }

    public void PlayExplosion()
    {
        _audioSource.PlayOneShot(_explosionClip);
    }
    public void PlayHospitalSound()
    {
        _audioSource.PlayOneShot(_hospitalMachinesClip);
    }

}
