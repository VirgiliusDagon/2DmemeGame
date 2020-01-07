﻿using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        HealthPotion1,
        HealthPotion2,
        HealthPotion3
    }

    public ItemType itemType;
    public Sprite icon;

    public static void SpawnItem(Item item, Vector2 position)
    {
        Transform newTransform = Instantiate(Prefabs.instance.itemPrefab, position, Quaternion.identity);
        newTransform.GetComponent<Item>().SetItem(item);

        newTransform.GetComponent<SpriteRenderer>().sprite = item.icon;
    }

    void Start()
    {
        icon = GetComponent<SpriteRenderer>().sprite;
    }

    public void SetItem(Item item)
    {
        itemType = item.itemType;
        icon = item.icon;
    }
}
