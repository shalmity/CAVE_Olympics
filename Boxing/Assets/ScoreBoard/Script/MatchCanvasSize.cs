using UnityEngine;

public class MatchCanvasSize : MonoBehaviour
{
    public GameObject originalObject; // 기존 객체를 Inspector에서 지정

    void Start()
    {
        // 기존 객체의 RectTransform 컴포넌트 가져오기
        RectTransform originalRectTransform = originalObject.GetComponent<RectTransform>();

        // 기존 객체의 크기 가져오기
        Vector2 originalSize = originalRectTransform.sizeDelta;

        // Canvas의 RectTransform 컴포넌트 가져오기
        RectTransform canvasRectTransform = GetComponent<RectTransform>();

        // Canvas의 크기를 기존 객체의 크기로 설정
        canvasRectTransform.sizeDelta = originalSize;
    }
}
