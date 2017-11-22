using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem {

    public enum WeapnTypes
    {
        SWORD,
            STAFF,
                DAGGER,
                    BOW,
                        SHIELD,
                            POLEARM
    }

    private WeapnTypes weaponType;
    private int spellEfectID;
     
    public WeapnTypes WeaponType {

        get { return WeaponType; }
        set { weaponType = value; }
    }

    public int SpellEfectID {
        get { return spellEfectID; }
        set { spellEfectID = value; }
    }
}
