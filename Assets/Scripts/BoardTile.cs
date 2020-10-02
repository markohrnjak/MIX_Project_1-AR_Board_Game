using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is attached to the tiles of the board, its purpose is to trigger effect on gameobjects that "collide with a tile".

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

        Debug.Log("Space enter");
        other.gameObject.GetComponent<Animator>().SetBool("Hit", true); //play "hit" animation
    }

    private void OnTriggerExit(Collider other)
    {
        //Put code here to execute when other no longer collided with
        this.GetComponent<Renderer>().material.color = Color.white;

        Debug.Log("Space exit");
        other.gameObject.GetComponent<Animator>().SetBool("Hit", false); //stop "hit" animation

    }
}
