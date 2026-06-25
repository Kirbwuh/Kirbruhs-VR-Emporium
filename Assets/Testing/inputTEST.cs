using UnityEngine;
using UnityEngine.InputSystem;

public class inputTEST : MonoBehaviour
{
    public InputActionProperty testAV; //InputActionProperty = an attribue of a object or class. testAV = name of property.
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InputActionProperty testBT;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float value = testAV.action.ReadValue<float>();
        Debug.Log("Value :" + value);

        bool button = testBT.action.IsPressed();
        Debug.Log("Button :" + button);
    }
}
