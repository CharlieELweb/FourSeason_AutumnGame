using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class Press : MonoBehaviour
{
    [SerializeField] private GameObject wineParticle;
    bool isBacking = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D) && !isBacking)
        {
            isBacking = true;
            transform.DOMoveY(0f, 0.2f)
                .SetEase(Ease.InSine)
                .OnComplete(() => {
                    transform.DOMoveY(10f, 1f)
                        .OnComplete(() =>
                        {
                            isBacking = false;
                        });
                    
                });
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "grape")
        {
            Debug.Log("HIT");
            Destroy(other.gameObject);
            Instantiate(wineParticle, transform.position + 5 * Vector3.down, transform.rotation);
        }
        
    }
}