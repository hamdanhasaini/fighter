using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEquipment : BaseStatItem {

    public enum EquipmentTypes {
        HEAD,
        CHEST,
        SHOULDER,
        LEGS,
        FEET,
        NECK,
        EARING,
        RING
    }

    private EquipmentTypes equipmentType;
    private int spellEfectID;

    public EquipmentTypes EqipmentType {
        get { return equipmentType; }
        set { equipmentType = value; }
    }

    public int SpellEfecrID{
        get { return spellEfectID; }
        set { spellEfectID = value; }
    }
}
