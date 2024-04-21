using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    [SerializeField] private AudioSource _music;
    //[SerializeField] private Rooms room;
    // Update is called once per frame
    [SerializeField] private AudioSource _BackgroundMusic;
    void Awake()
    {
        _BackgroundMusic.Play();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _music.Play();
            _BackgroundMusic.mute = true;
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        _music.Stop();
        _BackgroundMusic.mute = false;
    }

}
