using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigibodyPlayerCotronal : MonoBehaviour
{
    
    //����,��ȡһ��Player�ĸ������
    public Rigidbody player;
    void Start()
    {
        //�õ��������
        player = GetComponent<Rigidbody>();
        
    }

   
    void Update()
    {
        //��ȡunity�еĺ���������Horizontal
        float horizontal = Input.GetAxis("Horizontal");
        //��ȡunity�е�����������Vertical
        float vertical = Input.GetAxis("Vertical");

        //�����һ����ά����
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        //��ʼд�ٶ�
        if (dir != Vector3.zero)
        {
            //ͨ�������ƶ�,�ƶ��ٶ�Ϊÿ��7,�����ͨ��������ٶ����������ƶ�,����ǽ�岻���������������,��������Ŀû���ⷽ�������,���Բ�����ʹ�����ps:���ﲻ������deltaTime,��Ϊ������ٶ���ÿ����ٶ�,������ÿ֡���ٶ�
            //���о���,�ǵ�����rigibody����ת,��Ȼ�������б������
            player.velocity = dir * 7;
        }
    }
}
