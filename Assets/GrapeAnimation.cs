using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapeAnimation : MonoBehaviour
{
    private Animation animation;
    void Awake()
    {
        animation = GetComponent<Animation>();
    }
    // Start is called before the first frame update
    void Start()
    {
        animation.Play();
        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
