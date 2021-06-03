using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int space = 10;
    static protected Inventory s_InvetoryInstance;
    static public Inventory InventoryInstance {get { return s_InvetoryInstance; }}
    public List<Item> item = new List<Item>();

    public delegate void OnChange();

    public OnChange onChange;
    void Awake(){
        s_InvetoryInstance = this;
    }
    public void Add(Item newItem){
        if(item.Count < space)
        {
            item.Add(newItem);
            if(onChange != null)
            {
                onChange.Invoke();
            }
        }
        else{
            Debug.Log("No hay espacio disponible");
            }
    }

    public void Remove(Item itemToRemove){
        if(item.Contains(itemToRemove))
        {
            item.Remove(itemToRemove);
            if(onChange != null)
            {
                onChange.Invoke();
            }
        }
        else{
            Debug.Log("No se encuentra en la lista");
        }
    }
}
