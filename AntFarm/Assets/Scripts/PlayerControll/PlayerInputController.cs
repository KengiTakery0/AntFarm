using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInputController : MonoBehaviour
{
    InputSystem_Actions playerActions;
    InputSystem_Actions.UIActions UIActions;
    private void Awake()
    {
        playerActions = new InputSystem_Actions();

        UIActions = playerActions.UI;

        UIActions.Click.performed += ctx => GetTouch();
    }

    public void GetTouch()
    {
        Debug.Log(UIActions.Click.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
        playerActions.Enable();
    }
    private void OnDisable()
    {
        playerActions.Disable();
    }
}
