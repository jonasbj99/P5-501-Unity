using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IceClimbBehavior : MonoBehaviour
{
    [SerializeField] GameObject signObject;
    [SerializeField] TMP_Text climbTimeText;
    public static float climbTime = 0f;
    bool climbFinish;
    bool climbStart;

    void Update()
    {
        if (climbStart == true && climbFinish == false)
        {
            climbTime += Time.deltaTime;
        }
        else if (climbStart == true && climbFinish == true)
        {
            climbTimeText.text = "Time: " + climbTime.ToString("0.00");
            signObject.gameObject.SetActive(true);
            climbStart = false;
        }

        Debug.Log(climbTime);
    }

    public void ClimbStart()
    {
        climbStart = true;
    }

    public void ClimbFinish()
    {
        climbFinish = true;
    }
}
