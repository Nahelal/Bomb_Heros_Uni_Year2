using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using TMPro;

public class ConnectionButtonUI : NetworkBehaviour
{   
    //buttons and text ui on the players screen
    [SerializeField] private Button HostButton;
    [SerializeField] private Button ClientButton;
    [SerializeField] private TextMeshProUGUI playerCountText;

    //all clients are able to read the updating player variable
    private NetworkVariable<int> playerNumber = new NetworkVariable<int>(0, NetworkVariableReadPermission.Everyone);

    private void Awake()
    {
        //host button func to create and join server 
        HostButton.onClick.AddListener(() => 
        {
            NetworkManager.Singleton.StartHost();
        });

        //client button to join user to a pre-existing server
        ClientButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();
        });
    }

    private void Update()
    {   
        //changes text on the tmp component to update active players
        playerCountText.text = "Players:" + playerNumber.Value.ToString();

        if (!IsServer) return;
        //player count from list of connected clients on server
        playerNumber.Value = NetworkManager.Singleton.ConnectedClients.Count;

    }

}
