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
        #region ֪ʶ��һ �ű���ȡTMP UI���
        //1.��Ҫ����TMP�����ռ� TMPPro
        //2.TMP UI�����Ϊ TextMeshProUGUI
        #endregion

        #region ֪ʶ��� TMP UI�����������
        //1.�ı�����
        //text;
        tmpUIText.text = "123123adfasdklf545454564654654646454564654132156465424";

        //2.����
        //font
        //tmpUIText.font

        //3.�����С
        //fontSize
        //tmpUIText.fontSize = 10;

        //4.��ɫ
        //color
        tmpUIText.color = Color.black;

        //5.���뷽ʽ
        //alignment
        tmpUIText.alignment = TextAlignmentOptions.Center;

        //6.�м��
        //lineSpacing
        tmpUIText.lineSpacing = 50;


        //7.�Ƿ����ø��ı�
        //richText;
        tmpUIText.richText = false;

        #endregion

        #region ֪ʶ���� TMP UI������÷���
        //1.�����ı����ݣ�֧�ָ��ı���ʽ
        //SetText("<color=blue>Hello, World!</color>");
        tmpUIText.SetText("123123123123123");

        //2.ǿ�����¹����ı�����ͨ�����ı����ݻ���ʽ���ĺ�ʹ��
        //  Prelayout          ����ǰ����
        //  Layout             ����ʱ����
        //  PostLayout         ���ֺ����
        //  PreRender          ��Ⱦǰ����
        //  LatePreRender      ��Ⱦ�����
        //  MaxUpdateValue     ������
        //Rebuild(UnityEngine.UI.CanvasUpdate.LatePreRender);
        //tmpUIText.Rebuild(UnityEngine.UI.CanvasUpdate.Prelayout);

        //3.ǿ�Ƹ����ı�����,����ʱ��̬�����ı�ʱ
        //ForceMeshUpdate();
        //tmpUIText.ForceMeshUpdate();

        //4.��ȡ�ı����ַ���
        //text.Length;
        print(tmpUIText.text.Length);
        #endregion

        #region ֪ʶ���� UI�¼�����
        //���������ҪΪTMP UI�ռ���ӽ����¼�
        //����UGUI��EventTrigger�ķ�ʽ
        #endregion

        #region ֪ʶ���� ����API
        //https://docs.unity3d.com/Packages/com.unity.textmeshpro@4.0/api/TMPro.TextMeshProUGUI.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickTmpUI()
    {
        print("�ı��������");
    }
}
