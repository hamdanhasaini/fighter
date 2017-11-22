using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation  {

    public static void LoadAllInformation()
    {

        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInformation.Stamina = PlayerPrefs.GetInt("STAMINA");
        GameInformation.Endurance = PlayerPrefs.GetInt("ENDURANCE");
        GameInformation.Intellect = PlayerPrefs.GetInt("INTELLECT");
        GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");

        if (PlayerPrefs.GetString("EQUIMENTITEM1") != null) {
            GameInformation.EquimentOne =(BaseEquipment) PPSerialization.Load("EQUIMENTITEM1");
        }
    }

}
