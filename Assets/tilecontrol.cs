using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilecontrol:MonoBehaviour
{
    public int[] m_gridDim=new int[2]{6,6}; //width,height
    int m_gridsize;

    public tile[] m_tiles;

    void Start()
    {
        m_gridsize=m_gridDim[0]*m_gridDim[1];
        m_tiles=new tile[m_gridsize];
        for (int x=0;x<m_gridsize;x++)
        {
            m_tiles[x]=new tile(x);
        }

        print(m_tiles[0].m_tdata);
    }
}
