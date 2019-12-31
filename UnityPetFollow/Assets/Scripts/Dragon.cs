using UnityEngine;

public class Dragon : MonoBehaviour
{
    public Transform target,drag;

    private void Start()
    {
        target = GameObject.Find("目標").transform;
    }

    // 固定更新 : 一秒執行50次，處理物理行為
    private void FixedUpdate()
    {
        Track();
    }

    /// <summary>
    /// 跟隨玩家的目標
    /// </summary>
    private void Track()
    {
        Vector3 posD = drag.position;         // 恐龍
        Vector3 posT = target.position;       // 玩家目標

        posT.z += 8;      

        transform.position = Vector3.Lerp(posD, posT, 0.3f * Time.deltaTime );
    }
}
