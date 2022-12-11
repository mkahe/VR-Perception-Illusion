using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private bool isPlaying = false;
    public AudioSource audioSource;
    
    public void OnAudioButtonPlayClick()
    {
        if(isPlaying){
            audioSource.Pause();
        }
        else{
            audioSource.Play(0);
        }

        isPlaying = !isPlaying;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
