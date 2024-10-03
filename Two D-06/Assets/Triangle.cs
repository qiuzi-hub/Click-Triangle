using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triangle : MonoBehaviour
{
    public float maxHealth=100;//公共的最大血条
    private float health=100;//自己私有血条，字段小写字母开头

    //血量改变的时候发生这件事
    public UnityEvent<float> HpChangedEvent;

    //对字段进行访问
    //封装属性的目的
    //①在外可以访问，但是不能访问字段
    //通过属性修改字段，可以知道每一次血量的值
    public float Health {//属性 ，大写字母开头
        //get，set两个方法
        get => health;
        set
        //方法体
        {
            if(value>0 )
                health = value;
            HpChangedEvent?.Invoke(health / maxHealth); //传的是比例所以用/
        }
    }

    //因为点击鼠标左键的时候会减少血条，而血条是在Canvas下的
    //所以在Canvas下添加脚本
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Health -= 10;//血条每次减十，也可以小写的helath
            if (health < 0)//当小于0
            {
                Health = maxHealth;//回到最大血条
            }
            //Health = Health % maxHealth;//为啥要求余
        }
 
    }
}
