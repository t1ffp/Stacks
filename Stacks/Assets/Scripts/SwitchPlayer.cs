using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{

    public GameObject otherPlayer;
    public GameObject player2; 

    private void Start()
    {
        player2.GetComponent<PlayerController>().enabled = false;
    }

    private void OnMouseDown()
    {
        otherPlayer.GetComponent<PlayerController>().enabled = false;
        GetComponent<PlayerController>().enabled = true;
    }

}
