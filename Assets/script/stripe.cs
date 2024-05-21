using UnityEngine;

public class DynamicBar : MonoBehaviour
{
    public Transform hand1; // 第一个人的手部位置
    public Transform hand2; // 第二个人的手部位置

    public float width = 0.1f;  // 杆的宽度

    private void Update()
    {
        UpdateBarPositionAndScale();
    }

    void UpdateBarPositionAndScale()
    {
        // 计算两手位置的中点
        Vector3 midPoint = (hand1.position + hand2.position) / 2;

        // 计算两手之间的距离
        float length = (hand1.position - hand2.position).magnitude;

        // 设置杆的位置为两个手部位置的中点
        transform.position = midPoint;

        // 设置杆的旋转使其朝向第二个手的位置
        transform.LookAt(hand2.position, Vector3.up);

        // 根据两手的距离动态调整杆的长度
        transform.localScale = new Vector3(length, width, width);  // x轴scale设为两手之间的距离，y和z轴为宽度
    }
}