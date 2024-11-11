using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lesson12 : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI tmpUIText;

    public void OnPointerClick(PointerEventData eventData)
    {
        print("123");
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(tmpUIText,eventData.position,null);
        //如果不为-1 就证明点击到了一个超链接信息
        if(linkIndex != -1)
        {
            //这是得到超链接显示的文本信息
            print(tmpUIText.textInfo.linkInfo[linkIndex].GetLinkText());
            //这是得到富文本标签<link=?>中的?具体的地址信息
            print(tmpUIText.textInfo.linkInfo[linkIndex].GetLinkID());
        }

        int charIndex = TMP_TextUtilities.FindIntersectingCharacter(tmpUIText,eventData.position,null,true);
        if(charIndex != -1)
        {
            print(tmpUIText.textInfo.characterInfo[charIndex].character);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 TMP_TextUtilities类的作用
        //它是 TextMeshPro 中提供的一个实用工具类
        //包含多个常用方法，主要用于获取指定位置的文本信息
        //我们主要在点击文本时，利用该类来获取点击到的具体内容
        #endregion

        #region 知识点二 TMP_TextUtilities类中的常用API
        //下面的方法返回的都是索引值
        //如果没有获取到信息，返回的索引为-1
        //利用获取到的索引可以在TMP文本控件中的textInfo属性中的
        //linkInfo
        //wordInfo
        //characterInfo
        //lineInfo
        //来获取信息

        //1.获取给定位置文本中的具体信息
        //  获取链接索引：int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera)
        //  获取单词索引：int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera)
        //  获取单字符索引：int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera)
        //  获取行索引：int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera)

        //2.获取离给定位置最新的文本中的具体信息
        //  获取链接索引：int FindNearestLink(TMP_Text text, Vector3 position, Camera camera)
        //  获取单词索引：int FindNearestWord(TMP_Text text, Vector3 position, Camera camera)
        //  获取单字符索引：int FindNearestCharacterOnLine (TMP_Text text, Vector3 position, Camera camera)
        //  获取行索引：int FindNearestLine(TMP_Text text, Vector3 position, Camera camera)

        //更多API：
        //https://docs.unity3d.com/Packages/com.unity.textmeshpro@4.0/api/TMPro.TMP_TextUtilities.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
