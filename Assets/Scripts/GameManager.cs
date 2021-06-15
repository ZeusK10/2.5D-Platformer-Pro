using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance==null)
            {
                Debug.Log("Instance is NULL!!");
            }
            return _instance;
        }
    }
    public int lives = 3;

    private void Awake()
    {
        _instance = this;
    }

    private void Update()
    {
        if(lives<1)
        {
            SceneManager.LoadScene(0);
        }
    }
}
