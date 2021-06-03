using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : Interactable
{
    public Item items;
    public override void Interact()
    {
        //base.Interact();
        //llamar inventario y al metodo agregar
        Debug.Log("Funcion dentro de pickup");
        Destroy(this.gameObject);
        Inventory.InventoryInstance.Add(items);
        
    }
}
