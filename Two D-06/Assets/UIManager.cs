using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider HpSilder;//获取血条滑块
    public GameObject tri;
    public TMPro.TMP_Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        HpSilder.value = HpSilder.maxValue;//一开始血条的值是最大的
        if (tri == null)//如果忘记将三角形拖进去，可以用null进行判断
        {
            tri = GameObject.FindGameObjectWithTag("Player");//也可以通过player查找
        }
        tri.GetComponent<Triangle>().HpChangedEvent.AddListener(UpdateHpSilder);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //更新血条
    void UpdateHpSilder(float value) {
        HpSilder.value = value;//将更新的value值传给血条
    
    }
}
