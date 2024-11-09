using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        #region 知识点一 富文本标签是什么

        //富文本标签是在很多文本处理系统中使用的标记语言
        //允许通过特定的标签来格式化文本内容。
        //这些标签可以控制文本的样式、颜色、大小和其他视觉效果
        //从而增强文本的表现力

        //它的写法类似HTML或XML标签

        //<标签名>文本内容</标签>
        //或
        //<标签名="值">文本内容</标签>

        //不同的标签会为文本带来不同的表现效果

        #endregion 知识点一 富文本标签是什么

        #region 知识点二 富文本标签的主要作用

        //富文本标签的主要作用
        //是可以让我们在一个TMP文本控件中让一段文字呈现出各种不同的表现效果
        //让文本表现效果更具吸引力和生动性
        //常常用于游戏的 UI文本、聊天窗口、说明文本 等等文本显示相关的系统中

        #endregion 知识点二 富文本标签的主要作用

        #region 知识点三 常用富文本标签

        //1.换行
        //  <br>

        //2.文本加粗
        //  <b></b>

        //3.文本斜体
        //  <i></i>

        //4.加下划线
        //  <u></u>

        //5.改变大小
        //  <size=数值></size>

        //6.改变颜色
        //  <color=#RGBA 16进制></color>

        //7.对齐方式
        //  <align=left、center、right、justified、flush></align>

        //8.背景高亮
        //  <mark=#RGBA 16进制></mark>

        //9.透明度
        //  <alpha=#A 16进制>

        //10.全部大写
        //  <allcaps></allcaps>

        //11.改字体和材质（可选）
        //  <font="字体名" material="材质名"></font>

        //12.加上标(平方)
        //  <sup></sup>

        //13.加下标(化学式)
        //  <sub></sub>

        //14.超链接
        //  <link="链接"></link>

        #endregion 知识点三 常用富文本标签

        #region 知识点四 更多富文本标签

        //https://docs.unity3d.com/Packages/com.unity.textmeshpro@4.0/manual/RichTextSupportedTags.html

        #endregion 知识点四 更多富文本标签
    }

    // Update is called once per frame
    private void Update()
    {
    }
}