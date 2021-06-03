using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvetoryUI : MonoBehaviour
{
    private Inventory _inventory;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        _inventory = Inventory.InventoryInstance;
        _inventory.onChange += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)){
            panel.SetActive(!panel.activeSelf);
            UpdateUI();
        }    
    }
    void UpdateUI(){

        Debug.Log("Cambio el inventario");
        Slot[] slots = GetComponentsInChildren<Slot>();
        for(int i=0; i < slots.Length; i++){
            if( i < _inventory.item.Count){
            slots[i].setItem(_inventory.item[i]);
            }
            else{
                slots[i].Clear();
            }
        }
    }
}
