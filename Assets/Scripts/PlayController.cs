using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.ARFoundation;

public class PlayController : MonoBehaviour 
{  

    [SerializeField] private Button actionButton;
    [SerializeField] private GameObject sessionOrigin;
    private ARSessionOrigin arOrigin;
    private ARRaycastManager arRaycastManager;

    private SwipeHandler swipeHandler;

    private List<GameObject> dice;
    private List<Sprite> diceSprites;
    private GameObject diceSpawn;
    private Rigidbody rb;
    private TextMeshProUGUI textMeshPro;

    private int currentDice;

    void Start() 
    {
        arOrigin = FindObjectOfType<ARSessionOrigin>();
        arRaycastManager = FindObjectOfType<ARRaycastManager>();

        // Get dice info
        dice = DataHandler.instance.dice;
        diceSprites = DataHandler.instance.diceSprites;
        currentDice = 0; // we only have one type for just poc

        // Init swipe handler
        swipeHandler = new SwipeHandler();
        if (swipeHandler != null)
        {
            Debug.Log("swipeHandler init OK!");
            SetupSwipeToRoll();
        }
    }
    
    void Update() 
    {
        // Only perform swipe action at the moment
        if (swipeHandler.IsRollable) {
            swipeHandler.SwipeDice();
        }
        // TODO: case to handle check result 
    }

    private void SetupSwipeToRoll() 
    {
        diceSpawn = Instantiate(dice[currentDice]);
        if (swipeHandler != null && diceSpawn != null)
        {
            swipeHandler.Dice = diceSpawn;
            swipeHandler.UpdateDiePosition();
        }
    }
    

    public void OnSwipeToRollButton() 
    {
        swipeHandler.IsRolled = false;
        swipeHandler.IsRollable = true;
        SetupSwipeToRoll();
    }
}
