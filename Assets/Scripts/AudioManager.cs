using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _explosionClip;
    [SerializeField] private AudioClip _moveBodyClip;
    [SerializeField] private AudioClip _fallingClip;
    [SerializeField] private AudioClip _gruntClip;
    [SerializeField] private AudioClip _hospitalMachinesClip;
    [SerializeField] private AudioClip _introClip;
    [SerializeField] private AudioClip _endingClip;

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
        _audioSource.clip = _hospitalMachinesClip;
        _audioSource.volume = 0.04f;
        _audioSource.Play();
        _audioSource.loop = true;
    }
    public void PlayIntroSound()
    {
        _audioSource.clip = _introClip;
        _audioSource.volume = 0.01f;
        _audioSource.Play();
        _audioSource.loop = true;
    }

    public void PlayEndingSound()
    {
        _audioSource.clip = _endingClip;
        _audioSource.volume = 0.01f;
        _audioSource.Play();
        _audioSource.loop = true;
    }


    public void StopSound()
    {
        _audioSource.Stop();
    }
    
    
}
