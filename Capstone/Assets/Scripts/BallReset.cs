using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallReset : MonoBehaviour
{
    public GameObject pedestal;
    public GameObject ball;
    private Transform ballResetPosition;

    void Start()
    {
        for (int i = 0; i < pedestal.transform.childCount; i++)
        {
            Transform child = pedestal.transform.GetChild(i);
            if (child.name == "BallStartPosition")
            {
                ballResetPosition = child.transform;
                ball.GetComponent<Renderer>().material.color = Color.white;
                break;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            Rigidbody ballRigidBody = ball.GetComponent<Rigidbody>();
            ballRigidBody.velocity = Vector3.zero;
            ballRigidBody.angularVelocity = Vector3.zero;

            ball.transform.position = ballResetPosition.position;
            ball.GetComponent<Renderer>().material.color = Color.white;
        }
        else if (collision.collider.CompareTag("Goal"))
        {
            Rigidbody ballRigidBody = ball.GetComponent<Rigidbody>();
            ballRigidBody.velocity = Vector3.zero;
            ballRigidBody.angularVelocity = Vector3.zero;

            ball.transform.position = ballResetPosition.position;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Star"))
        {
            GameObject starObject = collider.gameObject;
            starObject.SetActive(false);
        }
    }
}
