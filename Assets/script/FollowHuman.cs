using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FollowHuman : MonoBehaviour
{
    private ARHumanBodyManager humanBodyManager;

    private void Awake()
    {
        // 获取场景中的ARHumanBodyManager组件
        humanBodyManager = FindObjectOfType<ARHumanBodyManager>();
    }

    private void OnEnable()
    {
        // 订阅人体变化事件
        humanBodyManager.humanBodiesChanged += OnHumanBodiesChanged;
    }

    private void OnDisable()
    {
        // 取消订阅人体变化事件
        humanBodyManager.humanBodiesChanged -= OnHumanBodiesChanged;
    }

    private void OnHumanBodiesChanged(ARHumanBodiesChangedEventArgs args)
    {
        foreach (var humanBody in args.added)
        {
            // 当检测到新的人体时，更新物体位置
            UpdatePosition(humanBody);
        }

        foreach (var humanBody in args.updated)
        {
            // 当已检测的人体位置更新时，也更新物体位置
            UpdatePosition(humanBody);
        }

        // 你也可以处理人体消失的情况，例如隐藏物体等
    }

    private void UpdatePosition(ARHumanBody humanBody)
    {
        // 这里使用人体的中心位置来更新物体的位置
        if (humanBody.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking)
        {
            Vector3 bodyPosition = humanBody.transform.position;
            transform.position = new Vector3(bodyPosition.x, transform.position.y, bodyPosition.z);
        }
    }
}