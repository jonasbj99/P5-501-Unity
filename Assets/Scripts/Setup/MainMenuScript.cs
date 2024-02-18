using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    XRIDefaultInputActions.DebugActions inputActions;

    void Awake()
    {
        inputActions = new XRIDefaultInputActions.DebugActions();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (inputActions.SpawnObject.ReadValue<float>() > 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void AxeThrowButton()
    {
        SceneManager.LoadScene("AxeThrow");
    }

    public void TugTankButton()
    {
        SceneManager.LoadScene("TugTheTank");
    }

    public void IceClimbButton()
    {
        SceneManager.LoadScene("IceClimb");
    }

    public void VeggieSamuButton()
    {
        SceneManager.LoadScene("VeggieSamurai");
    }
}
