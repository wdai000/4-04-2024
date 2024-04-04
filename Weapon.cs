using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

public void PrintWeaponStats()
{
    Debug.LogFormat("Weapon: {0} - {1} DMG", this.name, this.damage);
}