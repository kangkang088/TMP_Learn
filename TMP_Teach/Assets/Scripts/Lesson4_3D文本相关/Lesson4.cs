using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    public TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 3D文本和UI文本的区别
        //1.组件不同
        //  3D:TextMeshPro
        //  UI:TextMeshProUGUI
        //2.用途不同
        //  3D:主要用于在3D场景中显示文字
        //  UI:主要用于在UI中显示文字，具备UI相关的一些属性
        //3.渲染方式
        //  3D:直接渲染在场景上
        //  UI:通过UGUI的Canvas系统渲染
        //4.交互方式
        //  3D:一般通关添加碰撞器进行碰撞检测判断交互
        //  UI:一般利用UI系统的交互规则，比如EventTrigger

        //如何选择？
        //文本需要与3D场景交互需要在3D场景上显示，选择3D文本 TextMeshPro, 就把他当成3D物体处理即可
        //文本需要在UI系统中使用，选择 TextMeshProUGUI, 把它当成UI组件使用即可
        #endregion

        #region 知识点二 3D文本参数相关
        //和UI文本相关参数几乎一致
        #endregion

        #region 知识点三 3D文本脚本控制相关
        //组件名：TextMeshPro
        //属性方法也和UI组件几乎一致
        #endregion

        #region 知识点四 更多API
        //https://docs.unity3d.com/Packages/com.unity.textmeshpro@4.0/api/TMPro.TextMeshPro.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
