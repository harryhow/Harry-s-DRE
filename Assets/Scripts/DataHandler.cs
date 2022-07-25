using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataHandler : MonoBehaviour 
{
    #region Singleton
    public static DataHandler instance; 

    private void Awake() {
        instance = this;
    }
    #endregion

    [SerializeField] public List<GameObject> dice;
    [SerializeField] public List<Sprite> diceSprites;

}
