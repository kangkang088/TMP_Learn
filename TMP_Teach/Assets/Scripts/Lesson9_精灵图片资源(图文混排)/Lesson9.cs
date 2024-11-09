using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 精灵图片资源是什么？
        //精灵图片资源是配合富文本标签使用的资源
        //它可以让我们在TMP文本中显示图片，达到图文混排的目的

        //我们只需要创建并配置好精灵图片资源
        //便可以利用富文本标签在文本中显示图片
        #endregion

        #region 知识点二 精灵图片资源的创建
        //1.根据自己的需求建立一个图集纹理
        //  图集的
        //  Texture Type 为 Sprite
        //  Sprite Mode 为 Multiple
        //  并且我们需要在Sptie Editor中将图集中的图片划分为单独的Sprite(需要导入2D Sprite包)

        //2.准备好图集文件后
        //  在Project窗口中选中图集后 —> 右键 —> Text Mesh Pro —> Sprite Asset
        //  创建后，一般我们需要为每个图片进行
        //  2-1:名字设置
        //  2-2:位置宽度相关设置
        //      最好配合着使用来配置
        //      其中的参数和字体参数类似
        //      关键参数：
        //      BX、BY：相对于基线的原点的左上角
        //      AD：放置下一个内容时往右前进的位置
        //      为了方便，可以通过最下方的全局偏移和缩放进行设置
        #endregion

        #region 知识点三 精灵图片资源的使用
        //直接在TMP文本控件中输入sprite相关的富文本标签便可以使用

        //(默认资源中获取图片)
        //<sprite index=图片ID color=#RGBA的16进制(可选)>
        //或
        //<sprite name="图片名" color=#RGBA的16进制(可选)>
        //或
        //<sprite=图片ID color=#RGBA的16进制(可选)>

        //(指定资源中获取图片)
        //<sprite="资源名" index=图片ID color=#RGBA的16进制(可选)>
        //或
        //<sprite="资源名" name="图片名" color=#RGBA的16进制(可选)>

        //也可以将精灵图片资源直接关联给对应的TMP文本
        //若不关联，将使用默认资源
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
