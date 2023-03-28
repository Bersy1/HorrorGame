using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onFoot;
    public PlayerInput.UIActions uI;

    private PlayerMotor motor;
    private PlayerLook look;
    private PlayerLight _light;
    private InventoryManager _inventory;

    private void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        uI = playerInput.UI;
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();
        _light = GetComponent<PlayerLight>();
        _inventory = GetComponent<InventoryManager>();

        onFoot.Jump.performed += ctx => motor.Jump();
        onFoot.Flashlight.performed += ctx => _light.FlashlightState();
        onFoot.Lighter.performed += ctx => _light.LighterState();
        onFoot.OpenInv.performed += ctx => _inventory.ToggleInventory();
        uI.CloseInv.performed += ctx => _inventory.ToggleInventory();
        
    }

    private void FixedUpdate()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }
    private void Update()
    {

    }
    private void LateUpdate()
    {
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
        onFoot.Enable();
    }
    private void OnDisable()
    {
        onFoot.Disable();
    }
}
