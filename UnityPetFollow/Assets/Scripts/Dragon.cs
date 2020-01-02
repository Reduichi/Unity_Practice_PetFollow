using UnityEngine;

public class Dragon : MonoBehaviour
{
    public Transform target , drag;
    [Header("旋轉速度"), Range(0, 1000)]
    public float turn = 1.5f;
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 1.5f;

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
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        //if(v !=0) transform.LookAt(target);

        Vector3 posD = drag.position;           // 恐龍
        Vector3 posT = target.position*v;       // 玩家目標


        posT.x -= 2;
        posT.y = 0;
        posT.z -= 2;

        transform.Rotate(0, h * 10, 0);
        transform.position = Vector3.Lerp(posD, posT, 0.3f * Time.deltaTime * speed);
    }

}
