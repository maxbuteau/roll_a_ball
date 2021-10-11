using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{

    private float RotationX;
    private float RotationY;
    private float RotationZ;

    void Start()
    {
        RotationX = Random.Range(0, 45);
        RotationY = Random.Range(0, 45);
        RotationZ = Random.Range(0, 45);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(RotationX, RotationY, RotationZ) * Time.deltaTime);
    }
}
