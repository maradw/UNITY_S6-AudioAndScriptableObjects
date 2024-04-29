using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RoomScript : MonoBehaviour
{
    private AudioSource source;
    [SerializeField] private AudioSource _BackgroundMusic;
    [SerializeField] private AudioSource _Doors;
    public RoomSO _roomAudio;
    public static event Action OnCollisionEnter;
    public static event Action OnCollisionExit;

    void Awake()
    {
        source=GetComponent<AudioSource>();
        _BackgroundMusic.Play();
    }
    private void Start()
    {
         source.clip = _roomAudio._music;
    }

    private void OnTriggerEnter(Collider other)
    {
        MusicManager.Instance.PlayDoors();

        if (other.tag == "Player")
        {
            source.Play();
            _BackgroundMusic.mute = true;
            OnCollisionEnter?.Invoke();
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        MusicManager.Instance.PlayDoors();
        
        source.Stop();
        _BackgroundMusic.mute = false;
        OnCollisionExit?.Invoke();
        
    }

}
