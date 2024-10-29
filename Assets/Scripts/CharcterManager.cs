using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharcterManager : MonoBehaviour
{
    private static CharcterManager _instance;
    public static CharcterManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("CharcterManager").AddComponent<CharcterManager>();
            }
            return _instance;
        }
    }
    public Player _player;
    public Player Player
    {
        get { return _player; } 
        set { _player = value; }
    }
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
