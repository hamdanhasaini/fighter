using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItem {

    private string itemName;
    private string itemDescription;
    private int itemID;
    public enum itemTypes {
           EQUIPMENT,
           WEAPONG,
           SCROLL,
           POTION,
           CHEST
    }

    private itemTypes itemType;

    public string ItemName {
        get { return itemName; }
        set { itemName = value; }

    }


    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }

    }

    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }

    }

    public itemTypes ItemTypes
    {
        get { return itemType; }
        set { itemType = value; }
    }

}
