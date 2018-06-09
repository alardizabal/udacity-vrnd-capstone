using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaBomb : MonoBehaviour
{
    public GameObject lavaBomb;

    void Start()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            lavaBomb.SetActive(false);
            Logger.Log("Hit the ground");
        }
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            GameObject playerObject = collider.gameObject;
            Logger.Log("Hit the player");
        }
    }
}
