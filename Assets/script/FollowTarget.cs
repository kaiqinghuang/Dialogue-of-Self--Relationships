using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;  // 目标物体，跟随者将跟随这个物体

    void Update()
    {
        if (target != null)
        {
            // 设置跟随者的位置和旋转与目标一致
            transform.position = target.position;
            transform.rotation = target.rotation;
        }
    }
}
