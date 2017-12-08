using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text experienceDisplay; // variable Text qui peut être modifier 
    public UnityEngine.UI.Text epc; // variable Text qui peut être modifier 
    public float experience = 0.00f; // 
    public int experiencePerClick = 1;

    void Update()
    {
        experienceDisplay.text = "Experience: " + experience; // modification du text en fonction de la variable "experience" 
        epc.text = experiencePerClick + " experience/click"; // modification du text en fonction de la variable "experiencePerClick" 
    }

    public void Clicked()
    {
        experience += experiencePerClick;
    }

}
