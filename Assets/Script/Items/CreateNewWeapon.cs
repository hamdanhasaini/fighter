using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour {

    private BaseWeapon newWeapon;

    private void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.ItemID.ToString());
        Debug.Log(newWeapon.ItemTypes.ToString());
        Debug.Log(newWeapon.Stamina.ToString());
        Debug.Log(newWeapon.Endurance.ToString());
    }


    public void CreateWeapon() {
        
        newWeapon = new BaseWeapon();
        //asign name
        newWeapon.ItemName = "W" + Random.Range(1, 101);
        //new desct
        newWeapon.ItemDescription = "this is a new weapon.";
        //weapon id
        newWeapon.ItemID = Random.Range(1, 101);
        //stats
        newWeapon.Stamina = Random.Range(1, 11);
        newWeapon.Endurance = Random.Range(1, 11);
        newWeapon.Intellect = Random.Range(1, 11);
        newWeapon.Strenght = Random.Range(1, 11);
        //chose weapon type
        ChoseWeaponType();
        //spell effect id
        newWeapon.SpellEfectID = Random.Range(1, 101);

    }
    private void ChoseWeaponType()
    {

        int randomTemp = Random.Range(1, 7);
        if (randomTemp == 1)
        {
            newWeapon.WeaponType = BaseWeapon.WeapnTypes.SWORD;

        }
        else if(randomTemp == 2)
        {
            newWeapon.WeaponType = BaseWeapon.WeapnTypes.STAFF;

        }
        else if (randomTemp == 3)
        {
            newWeapon.WeaponType = BaseWeapon.WeapnTypes.DAGGER;

        }
        else if (randomTemp == 4)
        {
            newWeapon.WeaponType = BaseWeapon.WeapnTypes.BOW;

        }
        else if (randomTemp == 5)
        {
            newWeapon.WeaponType = BaseWeapon.WeapnTypes.SHIELD;

        }
        else if (randomTemp == 6)
        {
            newWeapon.WeaponType = BaseWeapon.WeapnTypes.POLEARM;

        }
    }
}
