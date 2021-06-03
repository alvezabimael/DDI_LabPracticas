using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType{

    Equip, Weapon, Medicine

}

[CreateAssetMenu (fileName = "New item", menuName = "Inventory generic")]
public class Item : ScriptableObject
{
    public ItemType itemType = ItemType.Equip;
    public Sprite icon = null;

    virtual public void Use(){
        Debug.Log($"Usando item {name}");
    }
}
