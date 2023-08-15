using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CardController : MonoBehaviour
{

    public Card card;
    public BoxCollider2D thisCard;
    public bool isMouseOver;

    private void Start()
    {
        thisCard = gameObject.GetComponent<BoxCollider2D>();
    }

    private void OnMouseOver()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }

}



public enum CardSprite
{
    // ������
    STRANAAS,
    STRANAINDONEZIA,
    // �������
    REGIONSSHAPKOY,
    REGIONCHELVPLASHE,
    REGINVOLOSATIYCHEL,
    REGIONCHELSGVOZDAMI,
    // ����� �����
    DEBAFKRIZIS,
    DEBAFPROFSOUZ,
    DEBUFINFLYATSIA,
    DEBUFNAVODNENIE,
    // ��������
    KULTUREGRECHKA,
    KULTUREROMANARCHITECT,
    KULTUREMBK,
    KULTUREAPELSINSOK,
    // �����
    WARGROM,
    WARKNIFE,
    WAROPLOT,
    WARSTRIKER,
    // ���������
    ECONOMSHAPKA,
    ECONOMSKOTOVODSTVO,
    ECONOMSHPRITC,
    ECONOMKYHONNIYINVENTAR,
    // �����
    NAYKABIOLOHIYA,
    NAYKATORIY,
    NAYKAFEDOR,
    NAYKAKREONIKA,
    // ������ �����
    XCARTA
}
