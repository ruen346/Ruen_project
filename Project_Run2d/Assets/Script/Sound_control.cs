﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_control : MonoBehaviour
{
    private AudioSource music;
    public AudioClip music_clip;
    public bool loop;
    int volume_num;

    // Start is called before the first frame update
    void Start()
    {
        music = this.gameObject.AddComponent<AudioSource>();
        music.clip = this.music_clip;
        music.loop = loop;

        music.Play();

        if (Game_system.get_sounds() == true)
            volume_num = 1;
        else
            volume_num = 0;

        music.volume = volume_num;
    }

    public void volume()
    {
        if (Game_system.get_sounds() == true)
            volume_num = 1;
        else
            volume_num = 0;

        music.volume = volume_num;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
