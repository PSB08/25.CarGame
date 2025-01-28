using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelResetCar : MonoBehaviour
{
    [SerializeField] private WheelCollider frontLeftCollider;
    [SerializeField] private Vector3 startTransform;
    [SerializeField] private GameObject parentObj;

    private void Update()
    {
        CheckForDeathGround();
    }

    private void ResetPosition()
    {
        parentObj.transform.position = startTransform;
        parentObj.transform.rotation = Quaternion.identity;
    }

    private void CheckForDeathGround()
    {
        WheelHit hit;

        if (frontLeftCollider.GetGroundHit(out hit) && hit.collider.CompareTag("DeathGround"))
        {
            ResetPosition();
        }
    }

}
