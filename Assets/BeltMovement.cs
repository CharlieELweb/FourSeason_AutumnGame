using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMovement : MonoBehaviour
{
    [SerializeField] private bool reverse = false;
    [SerializeField] private bool isCircle = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isCircle)
        {
            if(reverse)
            {
                transform.Rotate(0, 0, -90f * GameManager.Instance.movingSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(0, 0, 90f * GameManager.Instance.movingSpeed * Time.deltaTime);
            }
            
        }
        else
        {
            Vector2 dir;
            if(reverse)
            {
                dir = new Vector2(-0.04165f, 0);
            }
            else
            {
                dir = new Vector2(0.04165f, 0);
            }
            GetComponent<SpriteRenderer>().material.mainTextureOffset += dir * GameManager.Instance.movingSpeed * Time.deltaTime;
        }
        
        
    }
}
