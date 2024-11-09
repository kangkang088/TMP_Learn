using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 SDF是什么意思
        //SDF 是 有符号距离场 (Signed Distance Field) 的缩写
        //有符号(Signed)：指的是距离可以为正或负，表示一个点位于边界的内部（负值）还是外部（正值）
        //距离(Distance)：表示每个像素点到字符边缘的距离
        //场(Field)：指的是整个字体或图形周围的距离值的分布

        //是一种用于高质量文本和图形渲染的技术
        //尤其适用于缩放或在低分辨率下保持边缘平滑的情况

        //它的本质就是在一个Shader（着色器）中利用SDF相关算法规则来渲染文字
        //SDF 技术生成的字体纹理并不是普通的位图，而是基于每个像素到字体边缘的距离值。
        //这些距离值存储在纹理的灰度通道中，代表每个像素到字符边缘的距离信息。
        //然后在渲染时，着色器根据这些距离值动态计算字体的边缘，最终渲染出平滑的字符轮廓。

        //主要在TMP中用于生成和渲染文本，能让字体在任意大小或距离下保持清晰和锐利的效果
        #endregion

        #region 知识点二 SDF材质球指什么
        //我们创建的字体资源使用的材质球
        //本质上就是一个使用了SDF相关Shader的材质球
        //利用该Shader渲染出来的字体效果会更好
        //并且该Shader提供了很多可以被配置的参数
        //我们可以在对应字体的材质球中修改这些参数
        //从而让我们的字体实现一些更复杂的美术表现效果

        //因此我们需要学习字体材质球中的这些参数
        //从而帮助我们利用它来实现我们的表现需求
        #endregion

        #region 知识点三 SDF材质球中的主要内容
        //1.基础表面设置
        //2.边缘线效果设置
        //3.阴影(底层)效果设置
        //4.照明效果设置
        //5.发光效果设置
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
