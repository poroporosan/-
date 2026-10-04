using UnityEngine;

public class FrameRateController:MonoBehaviour
{
    void Awake()
    {
        QualitySettings.vSyncCount=0;
        Application.targetFrameRate=120;
    }
}