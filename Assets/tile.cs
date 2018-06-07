public class tile
{
    public int m_index;

    public int m_elevation=0;

    public basechar m_occupyChar;

    public string m_tdata;

    public tile()
    {
        m_tdata="aa";
    }

    public tile(int index)
    {
        m_index=index;
        m_tdata="a"+index;
    }
}
