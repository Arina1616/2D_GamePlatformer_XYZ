using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector2 _direction;
    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
        // Debug.Log(_direction);
    }

    private void Update()
    {
        if (_direction.x != 0 || _direction.y != 0 )
        {
            Vector3 move = new Vector3(_direction.x, _direction.y, 0) * _speed * Time.deltaTime;
            transform.position = transform.position + move;
        }
    }
}
