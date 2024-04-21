using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    [SerializeField] private AudioSource _music;
    //[SerializeField] private Rooms room;
    // Update is called once per frame
    [SerializeField] private AudioSource _BackgroundMusic;
    [SerializeField] private AudioSource _Doors;
    void Awake()
    {
        _BackgroundMusic.Play();
    }
    private void OnTriggerEnter(Collider other)
    {
        _Doors.Play();
        if (other.tag == "Player")
        {
            _music.Play();
            _BackgroundMusic.mute = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        _Doors.Play();
        _music.Stop();
        _BackgroundMusic.mute = false;
        
    }

}
