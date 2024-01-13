using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] protected Vector2 _worldPositon;
    [SerializeField] protected float _speedShip = 0.1f;
    private void FixedUpdate()
    {
        this._worldPositon = InputManager.Instance._worldPos;
        Vector3 _newPositon = Vector3.Lerp(transform.position,_worldPositon, this._speedShip);
        transform.parent.position = _newPositon;

    }


}
