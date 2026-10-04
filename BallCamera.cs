using UnityEngine;
using UnityEngine.InputSystem;

public class BallCamera : MonoBehaviour
{
    [SerializeField] private Transform target; // ボール（親のPlayerBall）
    
    // 通常時の追従オフセット（斜め後ろ）
    [SerializeField] private Vector3 normalOffset = new Vector3(0, 3.5f, -6.0f);
    // 上からの視点オフセット（真上から見下ろす）
    [SerializeField] private Vector3 topViewOffset = new Vector3(0, 10.0f, 0);

    [SerializeField] private float smoothTime = 0.15f; // カメラ移動の滑らかさ

    private Vector3 currentVelocity;

    void LateUpdate()
    {
        if (target == null) return;

        // スペースキーが押されているかどうかでオフセットを切り替え
        bool isTopView = false;
        if (Keyboard.current != null && Keyboard.current.spaceKey.isPressed)
        {
            isTopView = true;
        }

        // 目的のオフセットを決定
        Vector3 targetOffset = isTopView ? topViewOffset : normalOffset;
        Vector3 targetPosition = target.position + targetOffset;

        // カメラ位置を滑らかに移動
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime);

        // 向き（回転）の制御
        if (isTopView)
        {
            // 真上から真下を向く
            transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        }
        else
        {
            // 通常時はボールを注視する
            transform.rotation = Quaternion.LookRotation(target.position - transform.position);
        }
    }
}