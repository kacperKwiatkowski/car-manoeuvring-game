using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerContoller : MonoBehaviour
{
    public GameObject spinner;

    private float rotationSpeed = 200.0f;

    void Update()
    {
        spinner.transform.Rotate(Vector3.forward * rotationSpeed);
    }
}
