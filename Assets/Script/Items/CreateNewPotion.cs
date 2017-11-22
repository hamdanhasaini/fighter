using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewPotion : MonoBehaviour {

    private BasePotion newPotion;

    // Use this for initialization
    void Start() {
        CreatePotion();
        Debug.Log(newPotion.ItemName);
        Debug.Log(newPotion.ItemDescription);
        Debug.Log(newPotion.ItemID.ToString());
        Debug.Log(newPotion.PotionType.ToString());
        Debug.Log(newPotion.Stamina.ToString());
        Debug.Log(newPotion.Endurance.ToString());
    }

    private void CreatePotion(){
        newPotion = new BasePotion();
        newPotion.ItemName = "potion";
        newPotion.ItemDescription = "This potion";
        newPotion.ItemID = Random.Range(1, 101);
        ChosePotionType();
    }

    private void ChosePotionType()
    {
        
        int randomTemp = Random.Range(0, 7);
        if (randomTemp == 0)
        {
            newPotion.PotionType = BasePotion.potionTypes.HEALTH;

        }
        else if (randomTemp == 1)
        {

            newPotion.PotionType = BasePotion.potionTypes.ENERGY;
        }
        else if (randomTemp == 2)
        {

            newPotion.PotionType = BasePotion.potionTypes.ENDURANCE;
        }
        else if (randomTemp == 3)
        {

            newPotion.PotionType = BasePotion.potionTypes.STRENGTH;
        }
        else if (randomTemp == 4)
        {

            newPotion.PotionType = BasePotion.potionTypes.SPEED;
        }
        else if (randomTemp == 5)
        {

            newPotion.PotionType = BasePotion.potionTypes.INTELLECT;
        }
        else if (randomTemp == 6)
        {

            newPotion.PotionType = BasePotion.potionTypes.VITALITY;
        }
        

    }
}
