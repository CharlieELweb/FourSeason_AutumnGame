using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapeGenerator : MonoBehaviour
{
    private bool canGenerate = true;
    [SerializeField] private GameObject grapePrefab, grapeAnimationPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void GenerateGrape()
    {
        GameObject newGrape = Instantiate(grapePrefab, transform.position, transform.rotation);
    }

    void EnableGenerate()
    {
        canGenerate = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) && canGenerate && GameManager.Instance.grapeLeft > 0)
        {
            GameManager.Instance.grapeLeft--;
            Instantiate(grapeAnimationPrefab, transform.position, transform.rotation);
            Invoke("GenerateGrape", 1f);
            canGenerate = false;
            Invoke("EnableGenerate", 2f);
        }
    }
}
