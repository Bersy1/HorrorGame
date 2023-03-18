using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryStarter : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField]
    private InventoryUI inventoryUI;
    private void Awake()
    {
        inventory = new Inventory();
        inventoryUI.SetInventory(inventory);
    }
}
