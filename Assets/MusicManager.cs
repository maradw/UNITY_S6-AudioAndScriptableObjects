using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private Audio AudioSett;
    [SerializeField] private AudioMixer newSettAudio;
    //public Audio AudioSett;
    //public AudioMixer newSettAudio; 
    // Start is called before the first frame update

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
    void Update()
    {
        
    }
}
