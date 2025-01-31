using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCar : MonoBehaviour
{
    [SerializeField] private Vector3 startTransform;
    [SerializeField] private GameObject parentObj;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPosition();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            parentObj.transform.rotation = Quaternion.identity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("DeathGround"))
        {
            ResetPosition();
        }
    }

    private void ResetPosition()
    {
        parentObj.transform.position = startTransform;
        parentObj.transform.rotation = Quaternion.identity;
    }



}
