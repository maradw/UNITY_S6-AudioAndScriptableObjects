using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioSource [] _music = new AudioSource[1];
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnEnable()
    {
        //PlayerController.OnRoomEnter += Room1;
        //PlayerController.OnRoomEnter += Room2;
        //PlayerController.OnRoomEnter += Room3;
        //PlayerController.OnRoomEnter += Room4;
    }
    public void Room1()
    {
       // _music[0].Play();
    }
    public void Room2()
    {
        //_music[2].Play();
    }
    public void Room3()
    {
        //_music[3].Play();
    }
    public void Room4()
    {
        //_music[4].Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
