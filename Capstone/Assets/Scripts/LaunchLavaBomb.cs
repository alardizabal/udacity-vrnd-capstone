using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchLavaBomb : MonoBehaviour
{

    public GameObject lavaBomb;

    void Start()
    {
        LaunchBomb();
    }

    public void LaunchBomb()
    {
        Rigidbody lavaBombRigidbody = Instantiate(lavaBomb.GetComponent<Rigidbody>(), transform.position, transform.rotation) as Rigidbody;
        ;
        lavaBombRigidbody.AddForce(transform.forward * 800);
        GetComponent<AudioSource>().Play();
    }
}
