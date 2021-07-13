using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform PlayerHands;
    private bool gotcha_sth = false;
    private Rigidbody rbody;
    private BoxCollider bcol;
    
    private void Start() {
        rbody = GetComponent<Rigidbody>();
        bcol =  GetComponent<BoxCollider>();
    }
    private void Update() {
       if (Input.GetButtonDown("Fire1") && gotcha_sth == false) //No tengo nada y pulsa tecla: agarro
       {
        bcol.enabled = false;
        rbody.useGravity = false;
        this.rbody.position = PlayerHands.position;
        this.transform.parent = GameObject.Find("Holdstuff").transform;
        gotcha_sth = false;
       }
       if (Input.GetButtonUp("Fire1") && gotcha_sth == true) //Tengo algo y suelta tecla: suelto
       {
        bcol.enabled = true;
        rbody.useGravity = true;
        this.transform.parent = null;
        gotcha_sth = false;
       }
    }
    /*void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.rigidbody.position = PlayerHands.position;
        this.rigidbody.parent = GameObject.Find("Holdstuff").transform;
    }
    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
    }*/
}
