using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapeGenerator : MonoBehaviour
{
    [SerializeField] private GameObject grapePrefab;
    [SerializeField] private float grapeMovingSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void GenerateGrape()
    {
        GameObject newGrape = Instantiate(grapePrefab);
        newGrape.GetComponent<Grape>().movingSpeed = grapeMovingSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Invoke("GenerateGrape", 0f);
        }
    }
}
