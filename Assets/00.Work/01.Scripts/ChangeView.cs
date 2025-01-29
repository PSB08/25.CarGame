using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera[] cameras;

    private void Start()
    {
        mainCamera.enabled = true;
        cameras[0].enabled = false;
        cameras[1].enabled = false;
        cameras[2].enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            mainCamera.enabled = true;
            cameras[0].enabled = false;
            cameras[1].enabled = false;
            cameras[2].enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            mainCamera.enabled = false;
            cameras[0].enabled = true;
            cameras[1].enabled = false;
            cameras[2].enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            mainCamera.enabled = false;
            cameras[0].enabled = false;
            cameras[1].enabled = true;
            cameras[2].enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            mainCamera.enabled = false;
            cameras[0].enabled = false;
            cameras[1].enabled = false;
            cameras[2].enabled = true;
        }
    }

}
