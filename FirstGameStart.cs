using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class FirstGameStart : MonoBehaviour
{
    private bool isPaused = false;

    private void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            Debug.Log("リスタートボタンが押されました"); // テスト用ログ
            SceneManager.LoadScene("GameScene"); // 
            Time.timeScale = 1f; // ゲーム内の時間を通常速度に戻す
        });
    }
}