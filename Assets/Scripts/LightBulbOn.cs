using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightBulbOn : MonoBehaviour
{

    private string message;
    private float displayTime;
    private bool displayMessage = false;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "gate")
        {
            Debug.Log("Gate crossed");

            message = "ON";
            displayMessage = true;
            displayTime = 6f;
        }
    }
    void Update()
    {
        displayTime -= Time.deltaTime;
        if (displayTime <= 0.0)
        {
            displayMessage = false;
        }
    }

    void OnGUI()
    {
        if (displayMessage)
        {
            GUI.Label(new Rect(10, 10, 150, 20), message);
        }
    }

}
