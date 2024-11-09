using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 创建 TMP UI 文本对象
        //两种方式：
        //1.Hierarchy ——> UI ——> TextMeshPro相关控件
        //2.GameObject ——> UI ——> TextMeshPro相关控件
        #endregion

        #region 知识点二 UGUI相关组件
        //RectTransform 矩形变换组件在UGUI中有详细讲解，不赘述
        //Canvas Renderer 画布渲染器，也是UGUI相关知识，不赘述
        //  Cull Transparent Mesh(剔除透明网格):对于文本来说建议勾选上
        #endregion

        #region 知识点三 TextMeshPro - Text(UI)组件参数
        //我们可以将参数分成以下几部分进行讲解
        //1.输入相关
        //2.字体相关
        //3.颜色相关
        //4.间距相关
        //5.对齐相关
        //6.包裹溢出相关
        //7.UV映射相关
        //8.额外设置
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
