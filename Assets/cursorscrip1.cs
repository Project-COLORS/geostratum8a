﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorscrip1:MonoBehaviour
{
    public GameObject m_cam;
    public Rigidbody m_body;

    public Transform m_gridthing;

    /*-- movement vars --*/
    Vector3 m_moveVec=new Vector3();
    Vector3 m_posvec=new Vector3();
    float m_cursorspeed=7.6f;

    /*-- grid float vars, might deprecate later --*/
    Vector3 m_centrepos=new Vector3();
    float[] m_pos=new float[2]{0,0};

    float m_tileSize=1.12f;
    float m_tileSizehalf;

    void Start()
    {
        m_tileSizehalf=m_tileSize/2;

        m_centrepos.x=transform.position.x;
        m_centrepos.z=transform.position.z;
        m_centrepos.y=m_gridthing.position.y;
    }

    void Update()
    {
        transform.forward=-m_cam.transform.forward;

        m_moveVec.x=Input.GetAxisRaw("Vertical");
        m_moveVec.z=Input.GetAxisRaw("Horizontal");

        updatePosition();
        calcPos();
    }

    void updatePosition()
    {
        m_moveVec.Normalize();
        m_moveVec.x=m_moveVec.x*m_cursorspeed*-1;
        m_moveVec.z=m_moveVec.z*m_cursorspeed;
        // transform.Translate(m_moveVec,Space.World);
        m_body.velocity=m_moveVec;

        m_posvec=transform.position;
        m_posvec.x+=5;
        m_posvec.y+=4;
        m_posvec.z+=5;

        m_cam.transform.position=m_posvec;
    }

    void calcPos()
    {
        float diff=transform.position.x-m_centrepos.x;
        if (Mathf.Abs(diff)>=m_tileSizehalf)
        {
            if (diff>0)
            {
                m_pos[0]+=1;
                m_centrepos.x+=m_tileSize;
            }

            else
            {
                m_pos[0]-=1;
                m_centrepos.x-=m_tileSize;
            }

            m_gridthing.position=m_centrepos;
        }

        diff=transform.position.z-m_centrepos.z;
        if (Mathf.Abs(diff)>=m_tileSizehalf)
        {
            if (diff>0)
            {
                m_pos[1]+=1;
                m_centrepos.z+=m_tileSize;
            }

            else
            {
                m_pos[1]-=1;
                m_centrepos.z-=m_tileSize;
            }

            m_gridthing.position=m_centrepos;
        }
    }
}