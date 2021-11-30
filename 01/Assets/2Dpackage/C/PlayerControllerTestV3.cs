using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTestV3 : MonoBehaviour
{
    
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 rubyPostion = transform.position;
        rubyPostion.x = rubyPostion.x + Input.GetAxis("Horizontal") * moveSpeed;
        //print(Input.GetAxis(:Horizontal:));
        transform.position = rubyPostion;
    }
}