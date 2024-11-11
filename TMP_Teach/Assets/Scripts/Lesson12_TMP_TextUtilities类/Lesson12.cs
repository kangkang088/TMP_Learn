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
        //�����Ϊ-1 ��֤���������һ����������Ϣ
        if(linkIndex != -1)
        {
            //���ǵõ���������ʾ���ı���Ϣ
            print(tmpUIText.textInfo.linkInfo[linkIndex].GetLinkText());
            //���ǵõ����ı���ǩ<link=?>�е�?����ĵ�ַ��Ϣ
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
        #region ֪ʶ��һ TMP_TextUtilities�������
        //���� TextMeshPro ���ṩ��һ��ʵ�ù�����
        //����������÷�������Ҫ���ڻ�ȡָ��λ�õ��ı���Ϣ
        //������Ҫ�ڵ���ı�ʱ�����ø�������ȡ������ľ�������
        #endregion

        #region ֪ʶ��� TMP_TextUtilities���еĳ���API
        //����ķ������صĶ�������ֵ
        //���û�л�ȡ����Ϣ�����ص�����Ϊ-1
        //���û�ȡ��������������TMP�ı��ؼ��е�textInfo�����е�
        //linkInfo
        //wordInfo
        //characterInfo
        //lineInfo
        //����ȡ��Ϣ

        //1.��ȡ����λ���ı��еľ�����Ϣ
        //  ��ȡ����������int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera)
        //  ��ȡ����������int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera)
        //  ��ȡ���ַ�������int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera)
        //  ��ȡ��������int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera)

        //2.��ȡ�����λ�����µ��ı��еľ�����Ϣ
        //  ��ȡ����������int FindNearestLink(TMP_Text text, Vector3 position, Camera camera)
        //  ��ȡ����������int FindNearestWord(TMP_Text text, Vector3 position, Camera camera)
        //  ��ȡ���ַ�������int FindNearestCharacterOnLine (TMP_Text text, Vector3 position, Camera camera)
        //  ��ȡ��������int FindNearestLine(TMP_Text text, Vector3 position, Camera camera)

        //����API��
        //https://docs.unity3d.com/Packages/com.unity.textmeshpro@4.0/api/TMPro.TMP_TextUtilities.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
