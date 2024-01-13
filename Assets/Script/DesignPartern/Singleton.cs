using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] protected bool _dontDestroyOnLoad = true;
    private static T _Instance;
    public static T _instance
    {  get 
        {
            if(_Instance == null)
            {
                _Instance = FindObjectOfType<T>();
                if(_Instance == null)
                {
                    GameObject singleton = new GameObject(typeof(T).Name);
                    _Instance = singleton.AddComponent<T>();
                    DontDestroyOnLoad(singleton);
                }
            }
            return _Instance;
        } 
       
    }
    protected virtual void Awake()
    {
        if( _Instance != null )
        {
            _Instance = this as T;
            if(_dontDestroyOnLoad)
            {
                var root = transform.root;
                if (root != transform) DontDestroyOnLoad(root);
                else DontDestroyOnLoad(this.gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
