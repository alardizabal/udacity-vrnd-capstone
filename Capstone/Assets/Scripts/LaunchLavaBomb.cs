using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchLavaBomb : MonoBehaviour
{
    public static LaunchLavaBomb current;
    public GameObject pooledLavaBomb;
    public int bombAmount = 10;
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
        InvokeRepeating("LaunchBomb", 4.0f, 3.0f);
    }

    public GameObject GetPooledBomb()
    {
        bombPoolNum++;
        if (bombPoolNum > (bombAmount - 1))
        {
            bombPoolNum = 0;
        }
        Logger.Log(bombPoolNum);
        return pooledBombs[bombPoolNum];
    }

    public void LaunchBomb()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(Random.Range(-7, 7), Random.Range(0, 5), 0);
        GameObject bomb = LaunchLavaBomb.current.GetPooledBomb();
        bomb.SetActive(true);
        Rigidbody lavaBombRigidbody = bomb.GetComponent<Rigidbody>();
        lavaBombRigidbody.position = transform.position;
        lavaBombRigidbody.rotation = transform.rotation;
        lavaBombRigidbody.AddForce(transform.forward * Random.Range(1200, 2000));
        GetComponent<AudioSource>().Play();
    }
}
