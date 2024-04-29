using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{

    [SerializeField] private Audio AudioSett;
    [SerializeField] private AudioMixer newSettAudio;
    //[SerializeField] private Image volumeSetter;
    private AudioSource source;

   


    public static MusicManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        source = GetComponent<AudioSource>();
    }
    private void Start()
    {
        source.clip = AudioSett._doors;
        
    }
    public void Setmaster(float f)
    {
        AudioSett._master = f;
        newSettAudio.SetFloat("Master", Mathf.Log10(f) * 20f);
    }
    public void SetSFX(float f)
    {
        AudioSett._SFX = f;
        newSettAudio.SetFloat("SFX", Mathf.Log10(f) * 20f);
    }
    public void SetMusic(float f)
    {
        AudioSett._music = f;
        newSettAudio.SetFloat("Music", Mathf.Log10(f) * 20f);
    }
 
    public void PlayDoors()
    {
        source.Play();
    }

   



}
