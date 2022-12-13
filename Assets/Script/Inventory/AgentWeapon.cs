using Inventory.Model;
using Inventory.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class AgentWeapon : MonoBehaviour
{
    [SerializeField]
    private EquippableItemSO item;

    [SerializeField]
    private InventorySO inventoryData;

    [SerializeField]
    private UIItemUsed itemUsed;

    [SerializeField]
    private List<ItemParameter> parametersToModify, itemCurrentState;

    public void SetWeapon(EquippableItemSO weaponItemSO, List<ItemParameter> itemState) {
        if (item != null) {
            inventoryData.AddItem(item, 1, itemCurrentState);
        }
        itemUsed.unequipBtn.SetActive(true);
        this.item = weaponItemSO;
        this.itemCurrentState = new List<ItemParameter>(itemState);
        ModifyParameters();

        RequestDescriptionItem(weaponItemSO, itemState);

    }

    private void ModifyParameters()
    {
        foreach (var parameter in parametersToModify)
        {
            if (itemCurrentState.Contains(parameter)) {
                int index = itemCurrentState.IndexOf(parameter);
                float newValue = itemCurrentState[index].value + parameter.value;
                itemCurrentState[index] = new ItemParameter
                {
                    itemParameter = parameter.itemParameter,
                    value = newValue
                };
            }
        }
    }

    //=========================== Read Item Description==============================
    private void RequestDescriptionItem(EquippableItemSO weapon, List<ItemParameter> itemState)
    {
        ItemSO item = weapon;        
        string description = PrepareDescription(item, itemState);
        itemUsed.SetDescription(item.ItemImage, item.name, description);
    }

    private string PrepareDescription(ItemSO item, List<ItemParameter> itemState)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.item.Description);
        sb.AppendLine();
        for (int i = 0; i < itemState.Count; i++)
        {
            sb.Append($"{itemState[i].itemParameter.ParameterName} " +
                $": {itemState[i].value} / " +
                $"{item.DefaultParametersList[i].value}");
        }
        return sb.ToString();
    }
    //------------------END  Read Item Description----------------------------------------


    //=========================== Unequip Item Btn ==============================
    public void UnequipItem() {       
        inventoryData.AddItem(item, 1, itemCurrentState);
        this.item = null;
        this.itemCurrentState = null;
        itemUsed.ResetDescription();
        itemUsed.unequipBtn.SetActive(false);
    }
    //----------------------------END  Unequip Item Btn -------------------------



}
