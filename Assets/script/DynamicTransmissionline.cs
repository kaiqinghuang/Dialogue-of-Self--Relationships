using UnityEngine;

public class DynamicRibbonLine : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    public LineRenderer lineRenderer;
    public int pointsCount = 20;  // 线上的点数
    public float waveAmplitude = 1.0f;  // 波动的最大振幅
    public float waveFrequency = 1.0f;  // 波的频率
    public float gravityEffect = 0.5f;  // 重力影响的系数

    private void Update()
    {
        DrawDynamicRibbonLine();
    }

    void DrawDynamicRibbonLine()
    {
        lineRenderer.positionCount = pointsCount;
        float distance = Vector3.Distance(object1.position, object2.position);

        // 根据距离调整波动幅度和重力效果
        float amplitude = Mathf.Lerp(0.05f, waveAmplitude, distance / 50.0f);
        float gravity = Mathf.Lerp(0.0f, gravityEffect, distance / 50.0f);

        for (int i = 0; i < pointsCount; i++)
        {
            float t = (float)i / (pointsCount - 1);
            Vector3 pointPosition = Vector3.Lerp(object1.position, object2.position, t);

            // 计算波动和重力影响
            float waveOffset = Mathf.Sin(t * Mathf.PI * waveFrequency + Time.time) * amplitude * Mathf.Sin(t * Mathf.PI);
            float gravityOffset = gravity * (t - 0.5f) * (t - 0.5f);

            // 应用波动和重力
            pointPosition += lineRenderer.transform.up * waveOffset + lineRenderer.transform.forward * gravityOffset;

            lineRenderer.SetPosition(i, pointPosition);
        }
    }
}