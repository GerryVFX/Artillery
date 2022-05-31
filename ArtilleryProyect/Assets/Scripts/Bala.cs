using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    void Start()
    {
        
    }

    
    void Update()
    {
        Destroy(this.gameObject, 10f);
    }
}
