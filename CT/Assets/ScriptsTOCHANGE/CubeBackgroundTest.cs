using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBackgroundTest : MonoBehaviour
{
    private bool _isGoingRight = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = Time.deltaTime * 2;
        float distance = 50;
        
        if (_isGoingRight)
        {
            Vector3 rightEndPoint = new Vector3(150, 25, 1000);
            transform.position = Vector3.Lerp(transform.position, rightEndPoint, speed);
            
            if (Vector3.Distance(transform.position, rightEndPoint) <= distance)
                _isGoingRight = false;
        }
        else
        {
            Vector3 leftEndPoint = new Vector3(-500, 25, 1000);
            transform.position = Vector3.Lerp(transform.position, leftEndPoint, speed);

            if (Vector3.Distance(transform.position, leftEndPoint) <= distance)
                _isGoingRight = true;
        }
    }
}
