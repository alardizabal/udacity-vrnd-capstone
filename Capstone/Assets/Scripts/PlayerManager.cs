using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public GameStateManager gameManager;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("LavaBomb"))
        {
            GameObject playerObject = collider.gameObject;
            gameManager.PlayerLost();
            Logger.Log("Hit the player");
        }
    }
}
