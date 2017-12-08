using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public int tickValue;
    public int level;
    public string itemName;
    private float _baseCost;

    void Start()
    {
        _baseCost = cost;

    }

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nExperience: " + tickValue + " /s";

    }
    
    public void PurchaseItem()
    {
        if(click.experience >= cost)
        {
            click.experience -= cost;
            level += 1;
            cost = Mathf.Round(_baseCost * Mathf.Pow(1.15f, level));
        }

    }

}
