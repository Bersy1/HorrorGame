using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Items> itemList;



    public Inventory()
    {
        itemList = new List<Items>();

        Debug.Log("Inventory initialized");
    }


    public void AddItem(Items items)
    {
        itemList.Add(items);
    }
}
