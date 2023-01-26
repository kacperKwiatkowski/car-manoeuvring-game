using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
