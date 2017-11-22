using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotion : BaseStatItem {


        public enum potionTypes
    {
            HEALTH,
            ENERGY,
            STRENGTH,
            INTELLECT,
            VITALITY,
            ENDURANCE,
            SPEED

    }
    private potionTypes potionType;
    private int spellEffectID;

    public potionTypes PotionType
    {
        get { return potionType; }
        set { potionType = value; }

    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }

    }
}
