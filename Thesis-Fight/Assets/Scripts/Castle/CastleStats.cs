﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleStats : MonoBehaviour {

    public Stat Health { get; set; }
    public Stat Armor { get; set; }
    public int ArmorType { get; set; }

    private void Awake()
    {
        Health = new Stat("Health", "How much health the unit has.", 1000);
        // Armor
        // ArmorType
    }
}
