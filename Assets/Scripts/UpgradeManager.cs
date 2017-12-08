using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost; //Prix du Personnage
    public int level = 0; //Niveau du Personnage
    public int clickPower;
    public string itemName;
    private float _baseCost;

    void Start()
    {
        _baseCost = cost;

    }

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPower Per Click: +" + clickPower; // modification du text en fonction des variables "cost" et "clickPower"

    }

    public void PurchaseUpgrade()
    {
        if(click.experience >= cost)
        {
            click.experience -= cost;
            level += 1;
            click.experiencePerClick += clickPower;
            cost = Mathf.Round(_baseCost * Mathf.Pow(1.15f, level));

        }
    }

}
