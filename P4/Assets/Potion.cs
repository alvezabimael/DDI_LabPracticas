using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "Mana Potion", menuName = "Inventory/Potions")]
public class Potion : Item
{
    // Start is called before the first frame update
    public float manaAmount = 25.0f;
    public override void Use(){
        base.Use();
        Debug.Log("Se uso pocion de mana +25.00");
    }
    
}
