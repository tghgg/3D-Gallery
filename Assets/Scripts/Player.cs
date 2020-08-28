using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// See why the hell this line works
using UInput = UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public int SPEED = 100;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Helu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/api/UnityEngine.InputSystem.InputAction.CallbackContext.html
    // Docs on the InputAction.CallbackContext
    public void XinChao(UInput.InputAction.CallbackContext context)
    {
        Debug.Log("Xin chao");
        // Get the damn button
        Debug.Log(context.control);
    }

    public int OnMove(UInput.InputAction.CallbackContext context)
    {
        Debug.Log("Player movement detected");
        return 0;
    }
    public int OnOpenMenu()
    {
        Debug.Log("Open the menu");
        return 0;
    }
}
