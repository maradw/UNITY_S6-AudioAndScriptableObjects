using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Audio", menuName = "audio/Music", order = 1)]
public class Audio : ScriptableObject
{
    //[SerializeField] private AudioM
    /* [SerializeField] private float _master { get; set; }
     [SerializeField] private float _SFX;
     [SerializeField] private float _music;*/
    public float _master = 1f;
    public float _SFX= 1f;
    public float _music = 1f;
}
