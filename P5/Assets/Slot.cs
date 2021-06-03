using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public Item items;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void setItem(Item items)
    {   
        this.items = items;
        if(image != null){
            image.enabled= true;
            image.sprite = items.icon;
        }
        
    }
    public void Clear(){

        this.items = null;
        image.enabled = false;
    }

}
