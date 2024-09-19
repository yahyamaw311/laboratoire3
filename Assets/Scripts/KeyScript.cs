using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class KeyScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        
        if (other.collider.tag == "Player"){
            GameObject.Find("Door").GetComponent<ExitDoor>().foundKeys++;
            Destroy(gameObject);
        }
    }
}
