using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RestartButton : MonoBehaviour
{
    private void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            Debug.Log("リスタートボタンが押されました"); // テスト用ログ
            SceneManager.LoadScene("GameScene"); // 
        });
    }
}