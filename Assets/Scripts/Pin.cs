using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField] float _speed = 20f;
    [SerializeField] Rigidbody2D _rigidBody2D;
    [SerializeField] bool _isPinner = false;
     GameObject _Main;

    private void Awake()
    {
        _Main = GameObject.FindGameObjectWithTag("Main");
    }
    private void FixedUpdate()
    {
        if (!_isPinner)
        {
            _rigidBody2D.MovePosition(_rigidBody2D.position + Vector2.up * _speed * Time.deltaTime);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rotator"))
        {
            transform.SetParent(collision.gameObject.transform);
            collision.gameObject.GetComponent<Rotator>()._speed *= -1f;
            _Main.GetComponent<Score>()._score++;
            _isPinner = true;
        }
        else if (collision.gameObject.CompareTag("Pin"))
        {
            _Main.GetComponent<GameManager>().EndGame();
        }
    }
}
