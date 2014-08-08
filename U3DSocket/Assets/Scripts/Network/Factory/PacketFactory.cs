

//  PacketFactory.cs
//  Lu Zexi
//  2012-8-23


namespace Game.Network
{

    /// <summary>
    /// ������
    /// </summary>
    public abstract class PacketFactory
    {
        public abstract PacketBase Create();    //������
        public abstract int GetPacketId();      //��ȡ��ID
        public abstract int GetPacketSize();    //��ȡ����С
    }

}