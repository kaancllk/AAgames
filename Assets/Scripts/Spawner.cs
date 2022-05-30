using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _pinObject;
    [SerializeField] bool _isPin;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isPin = true;
        }
    }
    void SpawnPin()
    {
        if (_isPin)
        {
            Instantiate(_pinObject, transform.position, transform.rotation);
        }
        _isPin = false;
    }
    private void FixedUpdate()
    {
        SpawnPin();
    }
}
