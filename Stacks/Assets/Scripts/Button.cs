using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Button : MonoBehaviour
{
    public GameObject playerJail;
    public Text playerDialogue;



    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Crate")
        {
            playerJail.SetActive(false);
        }
    }
}
