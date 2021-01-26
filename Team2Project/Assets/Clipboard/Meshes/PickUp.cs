﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item" , menuName = "New Item/item")]
public class Item : ScriptableObject { 

    public string itemName;
    public ItemType itemType;
    public Sprite itemImage;
    public GameObject itemPrefab;

    public enum ItemType
    {
        일기,
        열쇠,
        해독제

    }
}