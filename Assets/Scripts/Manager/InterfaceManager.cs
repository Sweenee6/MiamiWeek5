using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField]
    private Button joinPlayerOne;
    [SerializeField]
    private Button joinPlayerTwo;
    [SerializeField]
    private Text playerOneText;
    [SerializeField]
    private Text playerTwoText;

    private bool pOneHere = false;
    private bool pTwoHere = false;


    [SerializeField]
    private SplitKeyboardPlayerInputManager playerInputManager;
    // Start is called before the first frame update
    void Start()
    {
        joinPlayerOne.onClick.AddListener(() => JoinPlayerOne());

        joinPlayerTwo.onClick.AddListener(() => JoinPlayerTwo());
        //TODO Listen for player two click event
    }

    private void JoinPlayerOne()
    {
        if(!pOneHere) {
            playerInputManager.JoinPlayer(0, "Keyboard&Mouse");
            playerOneText.text = "Leave Player One";
            pOneHere = true;
        }
        else if (pOneHere)
        {
            playerInputManager.LeavePlayer(0); //remove player
            pOneHere = false;
        }
        

        

        //TODO flip text to say "Leave Player One"
        //TODO on click after player has joined, remove player
    }
    private void JoinPlayerTwo()
    {
        if (!pTwoHere)
        {
            playerInputManager.JoinPlayer(1, "PlayerTwo");
            playerTwoText.text = "Leave Player Two";
            pTwoHere = true;
        }
        else if (pTwoHere)
        {
            playerInputManager.LeavePlayer(1); //remove player two
            pTwoHere = false;
        }

        //TODO on click after player has joined, remove player
    }

    //TODO Invoke JoinPlayer passing a playerIndex value and targeting a control scheme
    //TODO on click after player has joined, remove player
}
