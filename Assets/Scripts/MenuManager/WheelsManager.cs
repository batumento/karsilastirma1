using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsManager : MonoBehaviour
{
    [SerializeField] private int wheelSpeed = 30;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * wheelSpeed * Time.deltaTime);
    }
}
