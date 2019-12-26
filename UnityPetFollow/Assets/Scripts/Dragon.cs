using UnityEngine;

public class Dragon : MonoBehaviour
{
    [Header("速度"), Range(0, 100)]
    public float speed = 1.5f;

    private Transform player;

    private void Start()
    {
        player = GameObject.Find("野蠻人").transform;
    }
    // 在 Update 之後才執行 : 攝影機追蹤，物件追蹤
    private void LateUpdate()
    {
        Track();
    }

    /// <summary>
    /// 恐龍追蹤效果
    /// </summary>
    private void Track()
    {
        Vector3 posP = player.position;         // 野蠻人
        Vector3 posC = transform.position;      // 恐龍

        // 恐龍.座標 = 三維向量(A座標，B座標，百分比)
        transform.position = Vector3.Lerp(posC, posP, 0.3f * Time.deltaTime * speed);
    }
}
