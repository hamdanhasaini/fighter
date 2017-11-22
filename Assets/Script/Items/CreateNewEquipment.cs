using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewEquipment : MonoBehaviour {

    private BaseEquipment newEquipment;
    private string[] itemNames = new string[4] { "Common", "Great", "Amazing", "Insane" };
    private string[] itemDes = new string[2] { "New cool item", "Not so cool Item" };

	// Use this for initialization
	void Start () {
        CreateEquipment();
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log(newEquipment.ItemID.ToString());
        Debug.Log(newEquipment.EqipmentType.ToString());
        Debug.Log(newEquipment.Stamina.ToString());
        Debug.Log(newEquipment.Endurance.ToString());
    }

    private void CreateEquipment() {
        newEquipment = new BaseEquipment();
        newEquipment.ItemName = itemNames[Random.Range(0, 3)] + "item";
        newEquipment.ItemID = Random.Range(1, 101);
        ChoseItemType();
        newEquipment.ItemDescription = itemDes[Random.Range(0, itemDes.Length)];
        newEquipment.Stamina = Random.Range(1, 11);
        newEquipment.Endurance = Random.Range(1, 11);
        newEquipment.Intellect = Random.Range(1, 11);
        newEquipment.Strenght = Random.Range(1, 11);
    }

    private void ChoseItemType() {

        int randomTemp = Random.Range(1, 9);
        if (randomTemp == 1) {
            newEquipment.EqipmentType = BaseEquipment.EquipmentTypes.HEAD;

        }
        else if (randomTemp == 2)
        {
            newEquipment.EqipmentType = BaseEquipment.EquipmentTypes.SHOULDER;

        }
        else if (randomTemp == 3)
        {
            newEquipment.EqipmentType = BaseEquipment.EquipmentTypes.CHEST;

        }
        else if (randomTemp == 4)
        {
            newEquipment.EqipmentType = BaseEquipment.EquipmentTypes.LEGS;

        }
        else if (randomTemp == 5)
        {
            newEquipment.EqipmentType = BaseEquipment.EquipmentTypes.FEET;

        }
        else if (randomTemp == 6)
        {
            newEquipment.EqipmentType = BaseEquipment.EquipmentTypes.NECK;

        }
        else if (randomTemp == 7)
        {
            newEquipment.EqipmentType = BaseEquipment.EquipmentTypes.EARING;

        }
        else if (randomTemp == 8)
        {
            newEquipment.EqipmentType = BaseEquipment.EquipmentTypes.RING;

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
