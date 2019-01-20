using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass : MonoBehaviour {


    // Beginning of stats

    public int baseHP;
    public int baseMana;
    public int baseArmor;
    public int level;
    public int totalHP;
    public int bonusDamage;
    public bool isAlive;
    public int speed;
    public int currentHP;
    public int movementSpeed;

    // End of stats


    public void TakeDamage(int DamageTaken)
    {

    }
}
