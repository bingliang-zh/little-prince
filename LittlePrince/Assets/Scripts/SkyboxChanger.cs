using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    public AnimationCurve rCurve;
    public AnimationCurve gCurve;
    public AnimationCurve bCurve;

    public float cycleDurationInMin = 10;
    public float startTime = 0.5f;

    void Update()
    {
        float distancePerSec = 2f / cycleDurationInMin / 60;
        float curTime = startTime + distancePerSec * Time.deltaTime;
        startTime = curTime >= 2 ? curTime - 2 : curTime; // 以2为周期，0-1上升，1-2下降
        //float calTime = curTime > 1 ? 2 - curTime : curTime;
        float calTime = curTime;
        Color color = new Color(rCurve.Evaluate(calTime), gCurve.Evaluate(calTime), bCurve.Evaluate(calTime));
        Camera camera = GetComponent<Camera>();
        camera.backgroundColor = color;
    }
}
