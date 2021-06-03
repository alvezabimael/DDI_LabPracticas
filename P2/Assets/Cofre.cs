using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : Interactable
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();

    }
    public override void Interact()
    {
        Debug.Log("Se abrio el cofre");
    }
}
