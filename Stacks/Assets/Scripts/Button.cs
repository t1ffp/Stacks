using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Button : MonoBehaviour
{
    public GameObject playerJail;
    public GameObject playerText;


    private void Start()
    {
        playerText.gameObject.SetActive(false);
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Crate")
        {
            playerJail.SetActive(false);

            playerText.gameObject.SetActive(true);

        }
    }

}
