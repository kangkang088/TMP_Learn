using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    public TextMeshProUGUI tmpUIText;

    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 脚本获取TMP UI组件
        //1.需要引用TMP命名空间 TMPPro
        //2.TMP UI组件名为 TextMeshProUGUI
        #endregion

        #region 知识点二 TMP UI组件常用属性
        //1.文本内容
        //text;
        tmpUIText.text = "123123adfasdklf545454564654654646454564654132156465424";

        //2.字体
        //font
        //tmpUIText.font

        //3.字体大小
        //fontSize
        //tmpUIText.fontSize = 10;

        //4.颜色
        //color
        tmpUIText.color = Color.black;

        //5.对齐方式
        //alignment
        tmpUIText.alignment = TextAlignmentOptions.Center;

        //6.行间距
        //lineSpacing
        tmpUIText.lineSpacing = 50;


        //7.是否启用富文本
        //richText;
        tmpUIText.richText = false;

        #endregion

        #region 知识点三 TMP UI组件常用方法
        //1.设置文本内容，支持富文本格式
        //SetText("<color=blue>Hello, World!</color>");
        tmpUIText.SetText("123123123123123");

        //2.强制重新构建文本网格，通常在文本内容或样式更改后使用
        //  Prelayout          布局前调用
        //  Layout             布局时调用
        //  PostLayout         布局后调用
        //  PreRender          渲染前调用
        //  LatePreRender      渲染后调用
        //  MaxUpdateValue     最后调用
        //Rebuild(UnityEngine.UI.CanvasUpdate.LatePreRender);
        //tmpUIText.Rebuild(UnityEngine.UI.CanvasUpdate.Prelayout);

        //3.强制更新文本网格,运行时动态更改文本时
        //ForceMeshUpdate();
        //tmpUIText.ForceMeshUpdate();

        //4.获取文本中字符数
        //text.Length;
        print(tmpUIText.text.Length);
        #endregion

        #region 知识点四 UI事件监听
        //如果我们想要为TMP UI空间添加交互事件
        //可以UGUI中EventTrigger的方式
        #endregion

        #region 知识点五 更多API
        //https://docs.unity3d.com/Packages/com.unity.textmeshpro@4.0/api/TMPro.TextMeshProUGUI.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickTmpUI()
    {
        print("文本被点击了");
    }
}
