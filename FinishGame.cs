using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class FinishGame : MonoBehaviour
{
    private void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(Quit);
    }

    private void Quit()
    {
        Debug.Log("ゲーム終了ボタンが押されました！");

        #if UNITY_EDITOR
        // Unityエディタ実行時は再生を停止する
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // ビルドしたゲーム（exe等）ではアプリを終了する
        Application.Quit();
        #endif
    }
}