using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Crate1")
        {
            platform1.SetActive(true);
        }
        else if (other.tag == "Crate2")
        {
            platform2.SetActive(true);
        }
        else
        {
            platform1.SetActive(false);
            platform2.SetActive(false);
        }

       
     
    }

}
