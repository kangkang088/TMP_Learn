using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    public TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ 3D�ı���UI�ı�������
        //1.�����ͬ
        //  3D:TextMeshPro
        //  UI:TextMeshProUGUI
        //2.��;��ͬ
        //  3D:��Ҫ������3D��������ʾ����
        //  UI:��Ҫ������UI����ʾ���֣��߱�UI��ص�һЩ����
        //3.��Ⱦ��ʽ
        //  3D:ֱ����Ⱦ�ڳ�����
        //  UI:ͨ��UGUI��Canvasϵͳ��Ⱦ
        //4.������ʽ
        //  3D:һ��ͨ�������ײ��������ײ����жϽ���
        //  UI:һ������UIϵͳ�Ľ������򣬱���EventTrigger

        //���ѡ��
        //�ı���Ҫ��3D����������Ҫ��3D��������ʾ��ѡ��3D�ı� TextMeshPro, �Ͱ�������3D���崦����
        //�ı���Ҫ��UIϵͳ��ʹ�ã�ѡ�� TextMeshProUGUI, ��������UI���ʹ�ü���
        #endregion

        #region ֪ʶ��� 3D�ı��������
        //��UI�ı���ز�������һ��
        #endregion

        #region ֪ʶ���� 3D�ı��ű��������
        //�������TextMeshPro
        //���Է���Ҳ��UI�������һ��
        #endregion

        #region ֪ʶ���� ����API
        //https://docs.unity3d.com/Packages/com.unity.textmeshpro@4.0/api/TMPro.TextMeshPro.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
