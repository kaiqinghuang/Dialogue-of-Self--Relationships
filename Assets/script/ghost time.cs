using com.zibra.smoke_and_fire.DataStructures;
using UnityEngine;

public class SmokeDensityController : MonoBehaviour
{
    public float duration = 120.0f; // 设定时长为120秒
    public float maxDensity = 200.0f; // 最大密度值设为200
    private float startTime; // 开始时间
    private ZibraSmokeAndFireMaterialParameters smokeParameters; // 引用Zibra插件的脚本

    void Start()
    {
        startTime = Time.time; // 记录开始时间
        smokeParameters = GetComponent<ZibraSmokeAndFireMaterialParameters>(); // 获取脚本组件

        if (smokeParameters == null)
        {
            Debug.LogError("Smoke parameters component is not attached to the GameObject.");
        }
    }

    void Update()
    {
        if (smokeParameters == null) return;

        // 计算从开始到现在的时间差
        float timeElapsed = Time.time - startTime;

        // 根据时间差计算当前的 Smoke Density
        if (timeElapsed <= duration)
        {
            smokeParameters.SmokeDensity = (timeElapsed / duration) * maxDensity;
        }
        else
        {
            smokeParameters.SmokeDensity = maxDensity; // 时间超过120秒后，保持最大密度值不变
        }

        // 可选：输出当前的 Smoke Density 值进行调试
        Debug.Log("Current Smoke Density: " + smokeParameters.SmokeDensity);
    }
}