using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float maxMovingSpeed = 15f;
    public int grapeLeft = 3;
    public int grapeSuccess = 0;
    public float movingSpeed = 0f;
    public bool isOn = true;
    public bool gameEnd = false;
    public static GameManager Instance { get; private set; }
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        isOn = true;
        grapeLeft = 3;
    }

    void GameEnd()
    {
        isOn = false;
        gameEnd = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(grapeLeft == 0)
        {

            Invoke("GameEnd", 4f);
        }

        if(isOn)
        {
            DOTween.To(() => movingSpeed, x => movingSpeed = x, maxMovingSpeed, 4f);
        }
        else
        {
            DOTween.To(() => movingSpeed, x => movingSpeed = x, 0f, 4f);
        }
    }
}
