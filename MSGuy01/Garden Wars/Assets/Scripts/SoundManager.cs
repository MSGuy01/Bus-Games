using UnityEngine.Audio;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public Sound[] sounds;
    public String currentScene;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.Loop;
            s.source.mute = s.mute;
        }
    }
    private void Update()
    {
        currentScene = SceneManager.GetActiveScene().name;
        if (currentScene.Equals("Store"))
        {
            Debug.Log("store");
            //FindObjectOfType<Audiomanager>().stop("PixelMix");
            FindObjectOfType<SoundManager>().play("Walk");
        }
    }
    public void play(string name)
    {
        try
        {
            Sound s = Array.Find(sounds, sound => sound.name == name);
            s.source.Play();
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
    public void stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }
}
