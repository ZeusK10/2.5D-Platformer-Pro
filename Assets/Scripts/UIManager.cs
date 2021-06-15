using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if(_instance==null)
            {
                Debug.LogError("UIManager script is unassigned to gameobject");
            }
            return _instance;
        }
    }
    [SerializeField]
    private Text _coinText;
    public int coinCount;
    

    private void Awake()
    {
        _instance = this;
    }

    private void Update()
    {
        _coinText.text = "Coin: " + coinCount;
    }

}
