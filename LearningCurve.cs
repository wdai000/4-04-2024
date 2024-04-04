using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character();
        hero.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
