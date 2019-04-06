﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource startSound;
    public AudioSource backgroundSound;
    public AudioSource itsOgreSound;
    public bool silent = false;    
    // Start is called before the first frame update
    void Start() {
        if (silent) return;
        backgroundSound.Play();
        StartCoroutine(PlayStartSound());
    }

    IEnumerator PlayStartSound() {
        yield return new WaitForSeconds(3);
        backgroundSound.Pause();
        startSound.Play(0);   
        yield return new WaitForSeconds(startSound.clip.length);
        backgroundSound.Play();
    }

    public void PlayItsOgre() {
        itsOgreSound.Play();
    }
}
