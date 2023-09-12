using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerButton : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Player2")
        {
            door.gameObject.SetActive(false);

        }
        else
        {
            door.gameObject.SetActive(true);
        }
    }
}
