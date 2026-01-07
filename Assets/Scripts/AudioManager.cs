using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    
    public static AudioManager instance;
    [SerializeField] AudioMixer mixer;

    public AudioSource audioSource; //reference to the audio source component on the game object

    public const string MUSIC_KEY = "musicVolume";
    public const string SFX_KEY = "sfxVolume";

    void Awake()
    {
        // if instance is null, store a reference to this instance
        if (instance == null)
        {
            // a reference does not exist, so store it
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it
            // as we already have one
            Destroy(gameObject);
            return;
        }

        LoadVolume();


    }
    

    public void LoadVolume() // volume saved in volumesettings
    {
        float musicVolume = PlayerPrefs.GetFloat(MUSIC_KEY, 1f);
        float sfxVolume = PlayerPrefs.GetFloat(SFX_KEY, 1f);

        mixer.SetFloat(VolumeSettings.MIXER_MUSIC, Mathf.Log10(musicVolume) * 20);
        mixer.SetFloat(VolumeSettings.MIXER_SFX, Mathf.Log10(sfxVolume) * 20);
    }

}
