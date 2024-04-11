using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int startingHp = 100;
    public int currentHp;
    public int maxHp = 100;

    // Start is called before the first frame update
    void Start()
    {
        SetCurrentHp(startingHp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCurrentHp(int amount)
    {
        currentHp = amount;
    }

    public void SubtractHp(int amount)
    {
        currentHp -= amount;
        if(currentHp <= 0)
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
