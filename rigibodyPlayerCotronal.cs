using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigibodyPlayerCotronal : MonoBehaviour
{
    
    //首先,获取一个Player的刚体组件
    public Rigidbody player;
    void Start()
    {
        //拿到刚体组件
        player = GetComponent<Rigidbody>();
        
    }

   
    void Update()
    {
        //获取unity中的横向虚拟轴Horizontal
        float horizontal = Input.GetAxis("Horizontal");
        //获取unity中的纵向虚拟轴Vertical
        float vertical = Input.GetAxis("Vertical");

        //给玩家一个三维坐标
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        //开始写速度
        if (dir != Vector3.zero)
        {
            //通过刚体移动,移动速度为每秒7,这个是通过刚体的速度力来进行移动,靠近墙体不会产生抖动的现象,如果你的项目没有这方面的需求,可以不考虑使用这个ps:这里不用设置deltaTime,因为刚体的速度是每秒的速度,而不是每帧的速度
            //还有就是,记得锁定rigibody的旋转,不然会出现倾斜的现象
            player.velocity = dir * 7;
        }
    }
}
