using UnityEngine;

public class DynamicLine : MonoBehaviour
{
    public Transform object1;  // 第一个物体的 Transform
    public Transform object2;  // 第二个物体的 Transform

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        // 设置 LineRenderer 的初始位置
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, object1.position);
        lineRenderer.SetPosition(1, object2.position);
    }

    void Update()
    {
        // 每帧更新 LineRenderer 的端点位置
        lineRenderer.SetPosition(0, object1.position);
        lineRenderer.SetPosition(1, object2.position);
    }
}