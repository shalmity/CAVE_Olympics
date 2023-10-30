using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Update()
    {
        
    }

    public void MoveMain()
    {
        // 아무 키나 누르면 Main 씬으로 넘어가기
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Main");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            SceneManager.LoadScene("Main");
        }
    }

    public void Restart()
    {
        // 아무 키나 누르면 Main 씬으로 넘어가기
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Main");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
