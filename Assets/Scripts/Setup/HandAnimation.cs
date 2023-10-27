using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    public InputActionProperty thumbAnim;
    public InputActionProperty grabAnim;

    public Animator handAnim;

    private void Update()
    {
        float thumbValue = thumbAnim.action.ReadValue<float>();
        //Debug.Log("Thumb Value: " + thumbValue);
        handAnim.SetFloat("Thumb", thumbValue);

        float grabValue = grabAnim.action.ReadValue<float>();
        //Debug.Log("Grab Value: " + grabValue);
        handAnim.SetFloat("Grab", grabValue);
    }
}
