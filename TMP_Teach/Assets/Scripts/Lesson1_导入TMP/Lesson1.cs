using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 导入TMP相关资源
        //Untiy2020以上版本
        //两种方式:
        //方式一：Window ——> TextMeshPro ——> Import TMP Essential Resources(导入TMP基本资源)
        //方式二：在Hierarchy窗口中右键创建TMP相关的对象时，在弹出窗口中点击 Import TMP Essentials

        //导入成功后
        //会在Assets窗口中看到TextMesh Pro文件夹
        //其中就是TMP的相关基础资源
        #endregion

        #region 知识点二 导入TMP事例和附加功能
        //Untiy2020以上版本
        //两种方式:
        //方式一：Window ——> TextMeshPro ——> Import TMP Examples and Extras(导入TMP事例和附加功能)
        //方式二：在Hierarchy窗口中右键创建TMP相关的对象时，在上一步弹出的窗口中一起导入

        //导入成功后
        //在刚才的TextMesh Pro文件夹中
        //会多出一个 Examples & Extras文件夹

        //注意：
        //这一步不是强制的
        //但是在学习阶段，大家可以导入他们，帮助我们学习
        //可以查看其中的实例内容进行学习
        #endregion

        #region 知识点三 导入或更新TMP
        //对于老版本的Unity，并没有集成TMP
        //如果你想要自己获取它
        //只需要在Package Manager中进行下载即可
        //如果TMP存在版本更新，也可以在这里进行更新
        #endregion

        #region 知识点四 TMP的官方文档
        //官方说明文档
        //1. https://docs.unity3d.com/Packages/com.unity.textmeshpro@4.0/manual/index.html
        //2. TextMesh Pro ——> Documentation ——> TextMesh Pro User Guide 2016
        #endregion

        #region 总结
        //我们在正式使用学习TMP之前
        //需要导入它的必备资源和事例拓展内容

        //如果老版本中想要使用TMP
        //只需要在Package Manager中下载即可
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
