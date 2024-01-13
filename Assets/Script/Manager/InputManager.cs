using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    [SerializeField] public Vector2 _worldPos;
    private void Awake()
    {
        InputManager.Instance = this;
    }
    void FixedUpdate()
    {
        this.GetMousePos();
    }
    protected virtual void GetMousePos()
    {
        this._worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);   
    }
}
