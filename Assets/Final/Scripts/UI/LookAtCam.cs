using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.LookAt(Camera.main.transform);
    }
}
