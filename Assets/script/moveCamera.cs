using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float movementSpeed = 5f; // 摄像机移动速度
    public float rotationSpeed = 100f; // 摄像机旋转速度

    void Update()
    {
        // 摄像机移动控制
        float horizontalInput = Input.GetAxis("Horizontal"); // 获取水平方向输入（A/D，左右箭头键）
        float verticalInput = Input.GetAxis("Vertical"); // 获取垂直方向输入（W/S，上下箭头键）
        
        // 计算摄像机前进方向和侧向方向
        Vector3 forwardMovement = transform.forward * verticalInput;
        Vector3 rightMovement = transform.right * horizontalInput;

        // 更新摄像机位置
        transform.position += (forwardMovement + rightMovement) * movementSpeed * Time.deltaTime;

        // 摄像机旋转控制
        float rotationY = Input.GetAxis("Mouse X"); // 获取鼠标X方向移动
        float rotationX = Input.GetAxis("Mouse Y"); // 获取鼠标Y方向移动

        // 实现摄像机的水平和垂直旋转
        transform.Rotate(Vector3.up, rotationY * rotationSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.left, rotationX * rotationSpeed * Time.deltaTime);

        // 摄像机上升和下降控制
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position -= Vector3.up * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position += Vector3.up * movementSpeed * Time.deltaTime;
        }
    }
}