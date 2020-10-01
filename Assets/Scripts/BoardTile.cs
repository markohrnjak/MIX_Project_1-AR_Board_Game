using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//adds a box collider if the object does not have one
[RequireComponent(typeof(BoxCollider))]
public class BoardTile : MonoBehaviour
{
    public Color onCollisionColor;
    private BoxCollider coll;

    private void Awake()
    {
        coll = this.GetComponent<BoxCollider>();
        coll.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Put code here to execute when other is collided with
        this.GetComponent<Renderer>().material.color = onCollisionColor;
    }

    private void OnTriggerExit(Collider other)
    {
        //Put code here to execute when other no longer collided with
        this.GetComponent<Renderer>().material.color = Color.white;
    }
}
