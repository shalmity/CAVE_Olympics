using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            SceneManager.LoadScene("Main");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            SceneManager.LoadScene("Start");
        }
    }

    public void ToMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void ToStart()
    {
       
        SceneManager.LoadScene("Start");
        
    }
    
}
