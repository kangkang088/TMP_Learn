using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 颜色渐变预设的作用
        //让文本对象重复使用相同的颜色渐变
        //避免每次对文本单独进行设置，提高开发效率
        #endregion

        #region 知识点二 颜色渐变预设的创建和使用
        //创建：
        //Project窗口右键 —> TextMeshPro —> Color Gradient
        //创建好后，选中文件，在Inspector窗口即可开始编辑

        //使用：
        //在TMP文本中开启颜色渐变
        //拖入创建好的颜色渐变配置
        //注意：文本中颜色模式和配置文件中模式一致
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
