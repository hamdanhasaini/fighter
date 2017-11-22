using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour {

    public enum BatleState {
            START,
            PLAYERCHOICE,
            ENEMYCHOICE,
            LOSE,
            WIN
    }
    private BatleState currentState;

	// Use this for initialization
	void Start () {
        currentState = BatleState.START;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(currentState);

        switch (currentState)
        {
            case (BatleState.START):
                //settup batle funct
                break;

            case (BatleState.PLAYERCHOICE):
                break;

            case (BatleState.ENEMYCHOICE):
                break;

            case (BatleState.LOSE):
                break;

            case (BatleState.WIN):
                break;

        }
	}

    void OnGUI()
    {
        if(GUILayout.Button("NEXT STAGE"))
        {
            if (currentState == BatleState.START)
            {
                currentState = BatleState.PLAYERCHOICE;
            }else if(currentState == BatleState.PLAYERCHOICE)
            {
                currentState = BatleState.ENEMYCHOICE;

            }
            else if (currentState == BatleState.ENEMYCHOICE)
            {
                currentState = BatleState.LOSE;

            }
            else if (currentState == BatleState.LOSE)
            {
                currentState = BatleState.WIN;

            }
            else if (currentState == BatleState.WIN)
            {
                currentState = BatleState.START;

            }

        }
    }
}
