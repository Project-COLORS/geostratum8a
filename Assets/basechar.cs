using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basechar:MonoBehaviour
{
    cursorscrip1 m_cursor;

    void Start()
    {
        m_cursor=GameObject.Find("cursor").GetComponent<cursorscrip1>();
        move();
    }

    void move()
    {
        m_cursor.enterSelectMode(relocate);
    }

    void relocate()
    {
        Vector3 newpos=new Vector3(m_cursor.m_centrepos.x,.64f,m_cursor.m_centrepos.z);

        transform.position=newpos;
    }
}
