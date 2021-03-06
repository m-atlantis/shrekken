﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ChooseCharacter : MonoBehaviour{
    
    //hello
    public Sprite shrek;
    public Sprite shreik;
    public Sprite shrump;
    public Sprite shrobama;

    public string player1_name = "Shrek";
    public string player2_name = "Shrek";

    private TextMeshProUGUI player1_text;
    private TextMeshProUGUI player2_text;
    
    private SpriteRenderer player1_sprite;
    private SpriteRenderer player2_sprite;
    
    private int counter = 0;
    private Sprite[] shreks;


    public void Start() {
        player1_sprite = GameObject.Find("player1_sprite").GetComponent<SpriteRenderer>();
        player2_sprite = GameObject.Find("player2_sprite").GetComponent<SpriteRenderer>();
        player1_text = GameObject.Find("Player1_charactername").GetComponent<TextMeshProUGUI>();  
        player2_text = GameObject.Find("Player2_charactername").GetComponent<TextMeshProUGUI>();       
    }

    public void backToMain() {
        SceneManager.LoadScene("StartMenu");
    }

    public void playButton() {
        PlayerInfo.player1 = player1_name;
        PlayerInfo.player2 = player2_name;
        SceneManager.LoadScene("SampleScene");
    }

    public void selectShrek() {
        if (counter % 2 == 0) {
            player1_sprite.sprite = shrek;
            player1_name = "Shrek";
            player1_text.text = "Shrek";
        }
        else {
            player2_sprite.sprite = shrek;
            player2_name = "Shrek";
            player2_text.text = "Shrek";
        }
        counter++;
    }
    

    public void selectShreik() {
        if (counter % 2 == 0) {
            player1_sprite.sprite = shreik;
            player1_name = "Shreikh";
            player1_text.text = "Shreik";
        }
        else {
            player2_sprite.sprite = shreik;
            player2_name = "Shreikh";
            player2_text.text = "Shreik";
        }
        counter++;
    }

    public void selectShrump() {
        if (counter % 2 == 0) {
            player1_sprite.sprite = shrump;
            player1_name = "Shrump";
            player1_text.text = "Shrump";
        }
        else {
            player2_sprite.sprite = shrump;
            player2_name = "Shrump";
            player2_text.text = "Shrump";
        }
        counter++;
    }

    public void selectShrobama() {
        if (counter % 2 == 0) {
            player1_sprite.sprite = shrobama;
            player1_name = "Shrobama";
            player1_text.text = "Shrobama";
        }
        else {
            player2_sprite.sprite = shrobama;
            player2_name = "Shrobama";
            player2_text.text = "Shrobama";
        }
        counter++;
    }
    
}
