using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoundManager : MonoBehaviour
{
    public Sound[] sounds;

    // To help destroy duplications in inspector
    public static SoundManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        //Destroys duplicates of audiomanager
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        //have the option to change volume pitch and loop different clips
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    //Music player
    public void Start()
    {
        Play("Theme");
    }

    //play by finding the name attached
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        //So we don't get errors but warnings about the naming conventions
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }

    //And a stop method for when we want a looping sound to stop
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }
}
