using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Interactable : MonoBehaviour
{
    public bool isInside = false;
    //public KeyCode interactionKey = KeyCode.P;

    // Start is called before the first frame update

    public string interactionButton = "Interact";
    public virtual void Update(){
        if(isInside && CrossPlatformInputManager.GetButtonDown(interactionButton)){
            Interact();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player")){
            return;
        }
        Debug.Log("Entro al area");
        isInside = true;
    }
    void OnTriggerExit(Collider other){
        if(! other.CompareTag("Player")){
            return;
        }
        Debug.Log("Salio de el area");
        isInside = false;

    }
    public virtual void Interact(){
    }

}
