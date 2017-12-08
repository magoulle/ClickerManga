using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperiencePerSec : MonoBehaviour {

    public UnityEngine.UI.Text expDisplay;
    public Click click;
    public ItemManager[] items;

    public int GetExpPerSec()
    {
        int tick = 0;
        foreach (ItemManager item in items)
        {
            tick += item.level * item.tickValue;
        }
        return tick;
    }


    public void AutoExpPerSec()
    {
        click.experience += GetExpPerSec();

    }

    IEnumerator AutoTick()
    {
        while (true)
        {
            AutoExpPerSec();
            yield return new WaitForSeconds(1);
        }

    }


    void Start()
    {
        StartCoroutine(AutoTick());

    }


    void Update()
    {
        expDisplay.text = GetExpPerSec() + " experience/sec";

    }

}
