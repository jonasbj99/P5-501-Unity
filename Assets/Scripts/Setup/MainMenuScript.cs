using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void AxeThrowButton()
    {
        SceneManager.LoadScene("AxeThrow");
    }

    public void TugTankButton()
    {
        SceneManager.LoadScene("TovTræk");
    }

    public void IceClimbButton()
    {
        SceneManager.LoadScene("IceClimb");
    }

    public void VeggieSamuButton()
    {
        SceneManager.LoadScene("FruitNinja");
    }
}
