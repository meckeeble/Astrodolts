using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSend : MonoBehaviour
{
    private static void SendTCPData(Packet _packet)
    {
        _packet.WriteLength();
        GameClient.instance.tcp.SendData(_packet);
    }

    private static void SendUDPData(Packet _packet)
    {
        _packet.WriteLength();
        GameClient.instance.udp.SendData(_packet);
    }

    #region Packets
    public static void WelcomeReceived()
    {
        using (Packet _packet = new Packet((int)ClientPackets.welcomeReceived))
        {
            _packet.Write(GameClient.instance.myId);
            _packet.Write(UIManager.instance.usernameField.text);

            SendTCPData(_packet);
        }
    }

    public static void PlayerMovement(Vector3 _input)
    {
        using (Packet _packet = new Packet((int)ClientPackets.playerMovement))
        {
            //Packet length?
            _packet.Write(_input);
            _packet.Write(GameManager.players[GameClient.instance.myId].transform.rotation);
            SendUDPData(_packet);
        }
    }
    #endregion
}