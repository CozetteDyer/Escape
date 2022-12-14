using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicController : MonoBehaviour
{
    public Slider volumeSlider;
    public Toggle muteToggle;
    public GameObject ObjectMusic;
    public bool mute;
    public int muteInt;


    private float MusicVolume = 0f;
    
    private AudioSource AudioSource;
    // Start is called before the first frame update
    private void Start()
    {
        ObjectMusic = GameObject.FindWithTag("gameMusic");
        AudioSource = ObjectMusic.GetComponent<AudioSource>();

        MusicVolume = PlayerPrefs.GetFloat("volume");
        AudioSource.volume = MusicVolume;
        volumeSlider.value = MusicVolume;
        muteInt = PlayerPrefs.GetInt("mute");
        if (muteInt == 1)
        {
            muteToggle.isOn = true;
        }

    }

    // Update is called once per frame
    private void Update()
    {
        if (mute == true)
        {
            muteToggle.isOn = true;
        }

        if (!mute)
        {
            AudioSource.volume = MusicVolume;
            PlayerPrefs.SetFloat("volume", MusicVolume);
            PlayerPrefs.SetInt("mute", 0);
        } else
        {
            AudioSource.volume = 0f;
            PlayerPrefs.SetInt("mute", 1);
        }
        
        
        
    }
    
    public void volumeUpdater(float volume)
    {
        MusicVolume = volume;
    }

    public void muteUpdater(bool on)
    {
        if (on)
        {
            mute = true;

        } else
        {
            mute = false;
        }
    }

    public void musicReset()
    {
        PlayerPrefs.DeleteKey("volume");
        AudioSource.volume = 1;
        volumeSlider.value = 1;
    }
}
