using UnityEngine;
using UnityEngine.UI;

public class ToggleObjectVisibility : MonoBehaviour
{
    public GameObject objectToShowHide; // 需要显示或隐藏的游戏对象
    private bool isObjectVisible = true; // 初始状态为可见

    void Start()
    {
        // 获取按钮组件，并添加点击事件监听器
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ToggleVisibility);
    }

    void ToggleVisibility()
    {
        // 切换物体的可见性状态
        isObjectVisible = !isObjectVisible;
        objectToShowHide.SetActive(isObjectVisible);

        // 根据当前状态更新按钮文本
        Text buttonText = GetComponentInChildren<Text>();
        buttonText.text = isObjectVisible ? "Hide Object" : "Show Object";
    }
}