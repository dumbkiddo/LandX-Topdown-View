using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource currentMusic, gameOverMusic, victoryMusic;

    public AudioSource[] sfx;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // Play sound effects 
    public void PlaySFX(int sfxToPlay)
    {
        sfx[sfxToPlay].Stop();
        sfx[sfxToPlay].Play();
    }

    // Play music on victory screen 
    public void Victory()
    {
        currentMusic.Stop();

        victoryMusic.Play();
    }

    // Play music on Game Over screen 
    public void GameOver()
    {
        currentMusic.Stop();

        gameOverMusic.Play();
    }

}
