using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class StartButton : MonoBehaviour
{
    private void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            Debug.Log("メニューへボタンが押されました！"); // テスト用ログ
            SceneManager.LoadScene("StartScene"); // 読み込みたいシーン名
        });
    }
}