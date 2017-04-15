﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeysNotePlacementModePanelController : MonoBehaviour {
    public Button[] buttons;

    [HideInInspector]
    public static PlacementMode currentPlacementMode = PlacementMode.Sustain;

    void OnEnable()
    {
        //if (buttons.Length > 0)
           // buttons[0].onClick.Invoke();
    }
	
	// Update is called once per frame
	void Update () {
        // Shortcuts
        if (!Globals.IsTyping && !Globals.modifierInputActive)
        {
            if (Input.GetKeyDown("h"))                  // hold
                buttons[0].onClick.Invoke();
            else if (Input.GetKeyDown("b"))             // burst
                buttons[1].onClick.Invoke();
        }
    }

    public void SelectButton(Button button)
    {
        foreach (Button b in buttons)
        {
            b.interactable = (b != button);
        }
    }

    public void SetSustainMode()
    {
        currentPlacementMode = PlacementMode.Sustain;
    }

    public void SetBurstMode()
    {
        currentPlacementMode = PlacementMode.Burst;
    }

    public enum PlacementMode
    {
        Sustain, Burst
    }
}
