using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera _cam;
    [SerializeField]
    private float rayDistance = 3f;
    [SerializeField]
    private LayerMask _mask;
    private PlayerUI playerUI;
    private InputManager inputManager;
    // Start is called before the first frame update
    void Start()
    {
        _cam = GetComponent<PlayerLook>()._cam;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdateText(string.Empty);
        Ray _ray = new Ray(_cam.transform.position, _cam.transform.forward);
        Debug.DrawRay(_ray.origin, _ray.direction * rayDistance);
        RaycastHit hitInfo;
        if (Physics.Raycast(_ray, out hitInfo, rayDistance, _mask))
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
        }
    }
}
