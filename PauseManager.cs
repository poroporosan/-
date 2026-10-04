using UnityEngine;

public class PauseManager : MonoBehaviour
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
        else
        {
            Pause();
        }
    }

    private void Pause()
    {
        Time.timeScale = 0f; // ゲーム内の時間の流れを完全停止
        isPaused = true;

        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(true); // メニュー画面を表示
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