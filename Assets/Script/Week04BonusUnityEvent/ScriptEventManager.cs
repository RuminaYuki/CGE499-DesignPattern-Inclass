using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScriptEventManager : MonoBehaviour
{
    public static event Action IncreaseSizeEvent;
    public static event Action ReduceSizeEvent;

    public void IncreaseInput(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        IncreaseSizeEvent?.Invoke();
    }

    public void ReduceInput(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        ReduceSizeEvent?.Invoke();
    }
}
