using TMPro;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ TMP_TextEventHandler�������
        //���� TextMeshPro ���ṩ��һ������������
        //��Ҫ���ڴ����û���TMP�ı�֮��Ľ����¼�
        //��Ҫ�����Ǽ�������Ӧ TMP �ı��е��ض�������ǩ�������� <link> ���ض��ַ���
        //�ĵ���������ͣ�¼�
        //��������������ı���ĳЩ���ֽ��н���ʽ�����������ڴ����糬���ӡ�������ʾ��������Ϣ��Ч��
        #endregion

        #region ֪ʶ��� TMP_TextEventHandler���ʹ��
        //  ���ӣ�onLinkSelection ���� ���û���ͣ������ʱ����
        //  �ַ���onCharacterSelection ���� ���û���ͣĳ���ַ�ʱ����
        //  ���ʣ�onWordSelection ���� ���û���ͣĳ������ʱ����
        //  �У�onLineSelection ���� ���û���ͣĳһ���ı�ʱ����
        //  ����ͼƬ��onSpriteSelection ���� ���û���ͣĳһ����ͼƬʱ����

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
        print("**********������*************");
        print(linkInfo);
        print(linkText);
        print(index);
    }

    public void MyCharSelectionHandler(char charInfo,int index)
    {
        print("**********�ַ�*************");
        print(charInfo);
        print(index);
    }

    public void MySpriteSelectionHandler(char spirteInfo,int index)
    {
        print("**********����ͼƬ*************");
        print(spirteInfo);
        print(index);
    }

    public void MyWordSelectionHandler(string word,int beginIndex,int length)
    {
        print("**********����*************");
        print(word);
        print(beginIndex);
        print(length);
    }

    public void MyLineSelectionHandler(string lineInfo,int beginIndex,int length)
    {
        print("**********��*************");
        print(lineInfo);
        print(beginIndex);
        print(length);
    }
}
