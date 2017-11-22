﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    
    public static BaseEquipment EquimentOne { get; set; }
    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int Stamina { get; set; }
    public static int Endurance { get; set; }
    public static int Intellect { get; set; }
    public static int Strength { get; set; }

}
