using UnityEngine;
using UnityEngine.UI;

public class Panel_Size : MonoBehaviour
{
    [SerializeField] private RectTransform testPanel;

    void Start()
    {
        testPanel = GetComponent<RectTransform>();
        testPanel.sizeDelta = new Vector2(Screen.width, Screen.height);　//スクリーンサイズを取得
    }
}