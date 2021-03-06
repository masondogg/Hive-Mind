﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DN_Time : MonoBehaviour {
    public Text TimeText;
    public float Timer;
    public bool InfiniteTIme;
    public bool StartTimer;
	// Use this for initialization
	void Start () {
        TimeText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (InfiniteTIme == false && StartTimer)
        {
            Timer -= Time.deltaTime;
        }
        TimeText.text = Timer.ToString();
        if(Timer <= 0)
        {
            Timer = 0;
        }
	}
    public void IncreaseTimer()
    {
        Timer += 10;
    }
}
