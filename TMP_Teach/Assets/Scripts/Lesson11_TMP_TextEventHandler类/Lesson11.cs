using TMPro;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 TMP_TextEventHandler类的作用
        //它是 TextMeshPro 中提供的一个交互工具类
        //主要用于处理用户和TMP文本之间的交互事件
        //主要作用是监听并响应 TMP 文本中的特定区域或标签（如链接 <link> 和特定字符）
        //的点击和鼠标悬停事件
        //这个类可以让你对文本的某些部分进行交互式操作，适用于创建如超链接、工具提示、弹出信息等效果
        #endregion

        #region 知识点二 TMP_TextEventHandler类的使用
        //  链接：onLinkSelection —— 当用户悬停超链接时触发
        //  字符：onCharacterSelection —— 当用户悬停某个字符时触发
        //  单词：onWordSelection —— 当用户悬停某个单词时触发
        //  行：onLineSelection —— 当用户悬停某一行文本时触发
        //  精灵图片：onSpriteSelection —— 当用户悬停某一精灵图片时触发

        TMP_TextEventHandler tmpHandler = this.GetComponent<TMP_TextEventHandler>();
        tmpHandler.onLinkSelection.AddListener(MyLinkSelectionHandler);
        tmpHandler.onWordSelection.AddListener(MyWordSelectionHandler);
        tmpHandler.onLineSelection.AddListener(MyLineSelectionHandler);
        tmpHandler.onSpriteSelection.AddListener(MySpriteSelectionHandler);
        tmpHandler.onCharacterSelection.AddListener(MyCharSelectionHandler);

        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MyLinkSelectionHandler(string linkInfo,string linkText,int index)
    {
        print("**********超链接*************");
        print(linkInfo);
        print(linkText);
        print(index);
    }

    public void MyCharSelectionHandler(char charInfo,int index)
    {
        print("**********字符*************");
        print(charInfo);
        print(index);
    }

    public void MySpriteSelectionHandler(char spirteInfo,int index)
    {
        print("**********精灵图片*************");
        print(spirteInfo);
        print(index);
    }

    public void MyWordSelectionHandler(string word,int beginIndex,int length)
    {
        print("**********单词*************");
        print(word);
        print(beginIndex);
        print(length);
    }

    public void MyLineSelectionHandler(string lineInfo,int beginIndex,int length)
    {
        print("**********行*************");
        print(lineInfo);
        print(beginIndex);
        print(length);
    }
}
