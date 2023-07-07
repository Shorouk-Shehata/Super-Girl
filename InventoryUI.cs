using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI diamondText;
    private TextMeshProUGUI liveText;

    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
        liveText = GetComponent<TextMeshProUGUI>();

    }

    public void UpdateDiamondText(PlayerInventory playerInventory)
    {
        diamondText.text = playerInventory.NumberOfDiamonds.ToString();
    }

    public void UpdateLiveText(PlayerInventory playerInventory)
    {
        liveText.text = playerInventory.NumberOfLives.ToString();
    }
}
