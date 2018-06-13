using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInputManager : MonoBehaviour
{
    public SteamVR_TrackedObject trackedObj;
    public SteamVR_Controller.Device device;

    // Teleporation
    private LineRenderer laser;
    public GameObject teleportAimerObject;
    public Vector3 teleportLocation;
    public GameObject player;
    public LayerMask laserMask;
    private bool canTeleport;

    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        laser = GetComponentInChildren<LineRenderer>();
        laser.gameObject.SetActive(false);
        canTeleport = false;
    }

    void SetLaserStart(Vector3 startPos)
    {
        laser.SetPosition(0, startPos);
    }

    void SetLaserEnd(Vector3 endPos)
    {
        laser.SetPosition(1, endPos);
    }

    void Update()
    {
        device = SteamVR_Controller.Input((int)trackedObj.index);
        if (device.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            laser.gameObject.SetActive(true);
            teleportAimerObject.SetActive(true);
            SetLaserStart(gameObject.transform.position);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 15, laserMask))
            {
                teleportLocation = hit.point;
                laser.SetPosition(1, teleportLocation);
                // aimer position
                teleportAimerObject.transform.position = new Vector3(teleportLocation.x, teleportLocation.y + 0.5f, teleportLocation.z);
                canTeleport = true;
            }
            else
            {
                teleportLocation = transform.position + transform.forward * 15;
                RaycastHit groundRay;
                if (Physics.Raycast(teleportLocation, -Vector3.up, out groundRay, 17, laserMask))
                {
                    teleportLocation = new Vector3(transform.forward.x * 15 + transform.position.x, groundRay.point.y, transform.forward.z * 15 + transform.position.z);
                    canTeleport = true;
                }
                else
                {
                    canTeleport = false;
                }
                laser.SetPosition(1, transform.forward * 15 + transform.position);
            }
        }
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
        {
            laser.gameObject.SetActive(false);
            teleportAimerObject.SetActive(false);
            if (canTeleport) player.transform.position = teleportLocation;
        }
    }
}
