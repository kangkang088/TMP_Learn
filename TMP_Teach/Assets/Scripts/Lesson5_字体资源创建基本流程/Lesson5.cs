using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 字体资源创建基本流程
        //方式一：基于字体文件进行字体资源创建（常用）
        //  1.导入字体文件（后缀为 .ttf 或 .otf 格式的文件）
        //    一般放在文件夹 TextMesh Pro —> Fonts 中

        //  2.选中该字体 右键 —> Create —> TextMeshPro —> Font Asset
        //    创建好后 一般放在文件夹 TextMesh Pro —> Resources —> Fonts & Materials 中


        //方式二：直接打开创建字体资源窗口创建
        //  工具栏 —> Window —> TextMeshPro —> Font Asset Creator
        #endregion

        #region 知识点二 字体资源配置基本结构
        //1.基本信息设置
        //2.生成设置
        //3.图集和材质
        //4.字体粗细
        //5.后备字体资源
        //6.字符型
        //7.字形表
        //8.字形调整表
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
