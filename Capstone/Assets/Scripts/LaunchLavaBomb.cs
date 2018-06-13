using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchLavaBomb : MonoBehaviour
{
    public static LaunchLavaBomb current;
    public GameObject pooledLavaBomb;
    public int bombAmount = 4;
    public List<GameObject> pooledBombs;
    public static int bombPoolNum = 0;

    private void Awake()
    {
        current = this;
    }

    void Start()
    {
        pooledBombs = new List<GameObject>();
        for (int i = 0; i < bombAmount; i++)
        {
            GameObject obj = Instantiate(pooledLavaBomb);
            obj.SetActive(false);
            pooledBombs.Add(obj);
        }
    }

    public void StartLavaBombLauncher()
    {
        InvokeRepeating("LaunchBomb", Random.Range(3, 5), 3.0f);
    }

    public void StopLavaBombLauncher()
    {
        CancelInvoke();
    }

    public GameObject GetPooledBomb()
    {
        bombPoolNum++;
        if (bombPoolNum > (bombAmount - 1))
        {
            bombPoolNum = 0;
        }
        return pooledBombs[bombPoolNum];
    }

    public void LaunchBomb()
    {
        if (bombPoolNum == 0)
        {
            transform.rotation = transform.rotation * Quaternion.Euler(Random.Range(-1, 1), 0, 0);
        }
        GameObject bomb = LaunchLavaBomb.current.GetPooledBomb();
        bomb.SetActive(true);
        Rigidbody lavaBombRigidbody = bomb.GetComponent<Rigidbody>();
        lavaBombRigidbody.position = transform.position;
        lavaBombRigidbody.rotation = transform.rotation;
        lavaBombRigidbody.AddForce(transform.forward * Random.Range(1500, 2000));
        GetComponent<AudioSource>().Play();
    }
}
