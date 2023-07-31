using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Update()
    {
        // 아무 키나 누르면 Main 씬으로 넘어가기
        //오큘러스는 A 버튼 누르면 넘어감
        if (Input.anyKeyDown || OVRInput.GetDown(OVRInput.RawButton.A))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
