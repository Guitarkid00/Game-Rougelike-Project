using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource levelMusic;
    public AudioSource gameOverMusic;
    public AudioSource winMusic;

    public AudioSource[] SFX;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playGameOver()
    {

        levelMusic.Stop();

        gameOverMusic.Play();
        
    }

    public void playLevelWin()
    {
        levelMusic.Stop();

        winMusic.Play();
    }

    public void playSFX(int sfxToPlay)
    {
        SFX[sfxToPlay].Stop();

        SFX[sfxToPlay].Play();
    }
}
