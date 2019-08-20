using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreButtonPress : MonoBehaviour
{
    public Text text;
    public Button btnDecrease; // added reference to buttons so can disable them
    public Button btnIncrease;

    public int max = 50000;
    public int min = 10000;

    int currentAmount = 0;
    int increasePerClick = 10000;

    // from button click event, call AdjustValue(true) if want to increase or AdjustValue(false) to decrease
    public void AdjustValue(bool increase)
    {
        // clamp current value between min-max
        currentAmount = Mathf.Clamp(currentAmount + (increase ? increasePerClick : -increasePerClick), min, max);
        text.text = currentAmount.ToString();

        // disable buttons if cannot increase/decrease
        btnDecrease.interactable = currentAmount > min;
        btnIncrease.interactable = currentAmount < max;
    }
}
