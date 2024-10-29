using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    
    public PlayerController controller;

    private void Awake()
    {
        controller = GetComponent<PlayerController>();
        CharcterManager.Instance.Player = this;
    }
}
