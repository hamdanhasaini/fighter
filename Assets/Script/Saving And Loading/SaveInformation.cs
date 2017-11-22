﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation {

    public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("STAMINA", GameInformation.Stamina);
        PlayerPrefs.SetInt("ENDURANCE", GameInformation.Endurance);
        PlayerPrefs.SetInt("INTELLECT", GameInformation.Intellect);
        PlayerPrefs.SetInt("STRENGTH", GameInformation.Strength);

        if (GameInformation.EquimentOne != null)
        {
            PPSerialization.Save("EQUIMENTITEM1", GameInformation.EquimentOne);
        }
        Debug.Log("SAVED ALL INFORMATION");
    }
	
}
