using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchLavaBomb : MonoBehaviour
{

    public GameObject lavaBomb;

    void Start()
    {
        InvokeRepeating("LaunchBomb", 2.0f, 3.0f);
    }

    public void LaunchBomb()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        Rigidbody lavaBombRigidbody = Instantiate(lavaBomb.GetComponent<Rigidbody>(), transform.position, transform.rotation) as Rigidbody;
        ;
        lavaBombRigidbody.AddForce(transform.forward * Random.Range(1200,1900));
        GetComponent<AudioSource>().Play();
    }
}
