using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Canvas inventoryCanvas;
    private InputManager inputManager;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
    }

    public void ToggleInventory()
    {
        inventoryCanvas.enabled = !inventoryCanvas.enabled;
        if (inventoryCanvas.enabled)
        {
            inputManager.onFoot.Disable();
            inputManager.uI.Enable();
            Cursor.lockState = CursorLockMode.None;
        }else if (!inventoryCanvas.enabled)
        {
            inputManager.uI.Disable();
            inputManager.onFoot.Enable();
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
