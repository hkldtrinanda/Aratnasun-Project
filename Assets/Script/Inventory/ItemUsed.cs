using Inventory.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUsed : MonoBehaviour
{
    [SerializeField]
    private EquippableItemSO item;

    [SerializeField]
    private InventorySO inventoryData;

    [SerializeField]
    private List<ItemParameter> parametersToModify, itemCurrentState;

    public void SetItemUsed(EquippableItemSO weaponItemSO, List<ItemParameter> itemState)
    {
        if (item != null)
        {
            inventoryData.AddItem(item, 1, itemCurrentState);
        }

        this.item = weaponItemSO;
        this.itemCurrentState = new List<ItemParameter>(itemState);
    }
}