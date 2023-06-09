﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour {
    public Data brusher;
    public Data data;
    public AudioClip fudoff;
	public GameObject  game, ded, menu, and, golod;
    public static Interface regit { get; set; }

    private void Start()
    {
        Menue();
    }
    void Awake()
    {
        Menue();
        if (regit == null)
        {
            regit = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        regit = null;
    }
    public void Golod()
    {
        SoundPlayer.regit.sorse.PlayOneShot(fudoff);
        golod.SetActive(true);
        game.SetActive(false);
        menu.SetActive(false);
        and.SetActive(false);
        ded.SetActive(false);
        Time.timeScale = 0;
    }
    public void Andlevel(){
        brusher.record = 0;
        if (Time.timeScale == 1)
        {
            data.record += 1;
            Time.timeScale = 0;
        }
        golod.SetActive(false);
        game.SetActive(false);
        menu.SetActive(false);
        and.SetActive(true);
        ded.SetActive(false);

    }
	public void Menue(){
        Time.timeScale = 0;
        golod.SetActive(false);
        game.SetActive(false);
        menu.SetActive(true);
        and.SetActive(false);
        ded.SetActive(false);
	}
	public void Game(){
        Time.timeScale = 1;
        golod.SetActive(false);
        game.SetActive(true);
        menu.SetActive(false);
        and.SetActive(false);
        ded.SetActive(false);
    }
	public void Ded(){
        brusher.record = 0;
        Time.timeScale = 0;
        golod.SetActive(false);
        game.SetActive(false);
        menu.SetActive(false);
        and.SetActive(false);
        ded.SetActive(true);
    }

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab))
        {
            Menue();
        }
	}
}
