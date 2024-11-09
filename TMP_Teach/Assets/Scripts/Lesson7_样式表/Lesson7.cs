using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 什么是样式表
        //样式表是TMP提供的一个和 富文本标签 配合使用的功能
        //我们可以利用 样式表 自定义一种文本样式
        //然后在富文本中使用
        //<style="样式表名"></style> 标签包裹想要应用该样式的文字
        //相当于可以重复利用样式，避免每次书写相同、冗余的富文本样式编码

        //样式表的本质是富文本标签，相当于是对富文本标签的复用
        #endregion

        #region 知识点二 如何修改创建样式表
        //1.修改默认样式表
        //  Project窗口 —> TextMesh Pro —> Resources —> Style Sheets —> Default Style Sheet
        //  选中默认样式表配置后 可以在Inspector窗口修改 本质也是个ScriptableObject表
        //2.创建样式表
        //  Project窗口右键 —> TextMeshPro —> Style Sheet
        //  创建后，选中样式表文件 可以在Inspector窗口修改

        //一般情况下，我们无需新建样式表
        //在默认样式表中进行修改即可
        #endregion

        #region 知识点三 样式表配置
        //Name: 样式表名
        //HashCode：不可修改的唯一编码
        //Opening Tags:富文本标签开头
        //Closing Tags:富文本标签结尾

        //Up、Down：上下选择当前样式
        //+、-：增加删除新的样式
        //Previous、Next：样式比较多时，用来翻页
        #endregion

        #region 知识点四 样式表设置
        //每一个TMP控件中的额外设置中
        //都可以关联对应的样式表资源
        //如果没有设置，会使用默认样式表
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
