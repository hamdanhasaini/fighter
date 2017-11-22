using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        LoadInformation.LoadAllInformation();
        Debug.Log("player Name : " + GameInformation.PlayerName);
        Debug.Log("Player Level : " + GameInformation.PlayerLevel);
        Debug.Log("Player Stamina : " + GameInformation.Stamina);
        Debug.Log("player Endurance : " + GameInformation.Endurance);
        Debug.Log("Player Intellect : " + GameInformation.Intellect);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
