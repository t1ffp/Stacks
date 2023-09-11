using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;
using Cinemachine;

public class SwitchPlayer : MonoBehaviour
{

    public GameObject otherPlayer;
    public GameObject player2;

   
    public CinemachineVirtualCamera otherPlayerCam;

    public GameObject player2Cam;

    public bool trackMe;


    private void Start()
    {
        player2.GetComponent<PlayerController>().enabled = false;
        //otherPlayerCam.enabled = false;
        //player2Cam.GetComponent<CinemachineVirtualCamera>.enabled = false;

        if(trackMe == true)
        {
            otherPlayerCam.Follow = gameObject.transform;
        }
            
        
    }

    private void OnMouseDown()
    {
        otherPlayer.GetComponent<PlayerController>().enabled = false;
        GetComponent<PlayerController>().enabled = true;

        //otherPlayerCam.enabled = true;
        //GetComponent<CinemachineVirtualCamera>.enabled = false;
        otherPlayerCam.Follow = gameObject.transform;
    }

}
