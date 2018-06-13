using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaBomb : MonoBehaviour
{
    public GameObject lavaBomb;

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody bombRigidBody = lavaBomb.GetComponent<Rigidbody>();
        bombRigidBody.velocity = Vector3.zero;
        bombRigidBody.angularVelocity = Vector3.zero;
        lavaBomb.SetActive(false);
    }
}
