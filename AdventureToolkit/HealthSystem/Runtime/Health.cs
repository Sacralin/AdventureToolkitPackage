using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int startingHp = 50;
    public int currentHp;
    public int maxHp = 100;

    public Slider healthSlider;


    // Start is called before the first frame update
    void Start()
    {
        SetCurrentHp(startingHp);
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = currentHp;
        Debug.Log(currentHp);
    }

    public void IncreaseHealthButton()
    {
        AddHp(5);
    }

    public void DecreaseHealthButton()
    {
        SubtractHp(5);
    }

    public void SetCurrentHp(int amount)
    {
        currentHp = amount;
    }

    public void SubtractHp(int amount)
    {
        currentHp -= amount;
        if (currentHp <= 0)
        {
            currentHp = 0;
        }
    }

    public void AddHp(int amount)
    {
        currentHp += amount;
        if (currentHp >= maxHp)
        {
            currentHp = maxHp;
        }
    }
}
