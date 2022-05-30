using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float _speed =100f;
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, _speed * Time.deltaTime);
    }
}
