using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour {

    private BasePlayer newPlayer;
    private bool isMageClass;
    private bool isWarriorClass;
    private string playerName = "enter name !";

	// Use this for initialization
	void Start () {
        newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName,15);
        isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");

        if (GUILayout.Button("Create"))
        {
            if (isMageClass)
            {
                newPlayer.PlayerClass = new BaseMageClass();

            }else if (isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
            }
            newPlayer.PlayerLevel = 1;
            newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
            newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
            newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
            newPlayer.Strength = newPlayer.PlayerClass.Strength;
            newPlayer.PlayerName = playerName;

            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();

            Debug.Log("player Name: " + newPlayer.PlayerName);
            Debug.Log("player class: " + newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("player level: " + newPlayer.PlayerLevel);
            Debug.Log("player Stamina: " + newPlayer.Stamina);
            Debug.Log("player Endurance: " + newPlayer.Endurance);
            Debug.Log("player Intellect: " + newPlayer.Intellect);
            Debug.Log("player Strenght: " + newPlayer.Strength);

        }

        if (GUILayout.Button("Load"))
        {
            Application.LoadLevel("tset");
        }

    }
    private void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = newPlayer.PlayerName;
        GameInformation.PlayerLevel = newPlayer.PlayerLevel;
        GameInformation.Stamina = newPlayer.Stamina;
        GameInformation.Endurance = newPlayer.Endurance;
        GameInformation.Intellect = newPlayer.Intellect;
        GameInformation.Strength = newPlayer.Strength;
    }
}
