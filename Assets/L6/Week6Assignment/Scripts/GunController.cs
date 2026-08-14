using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] LineRenderer aimLine;
    [SerializeField] Transform muzzle;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Vector3 aimPoint;

        if (Physics.Raycast(ray, out hit))
            aimPoint = hit.point;
        else
            aimPoint = ray.origin + ray.direction * 100f;

        Vector3 direction = aimPoint - muzzle.position;
        transform.rotation = Quaternion.LookRotation(direction);

        aimLine.positionCount = 2;
        aimLine.SetPosition(0, muzzle.position);
        aimLine.SetPosition(1, aimPoint);
    }
}