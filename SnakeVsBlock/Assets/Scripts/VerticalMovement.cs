using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f; 

        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.up * speed * Time.deltaTime);
        
        
    
        
    }
}
