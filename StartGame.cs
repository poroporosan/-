using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI; 
    private bool isPaused = false;

    // ボタンを押したときに実行する関数
    public void TogglePause()
    {
        if (isPaused)
        {
            Resume();
        }
    }

    private void Resume()
    {
        Time.timeScale = 1f; // ゲーム内の時間を通常速度に戻す
        isPaused = false;

        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(false); // メニュー画面を非表示
        }
    }
}