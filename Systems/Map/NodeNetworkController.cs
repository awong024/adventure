using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeNetworkController : MonoBehaviour {
    [SerializeField] NodeNetworkView nodeNetworkView;

    List<List<NetworkNode>> networkNodes; //Mapped like 2D array [row, position]

    void Start() {
        Map map = new Map();
        map.GenerateNodeMap();

        networkNodes = nodeNetworkView.GenerateNodeNetwork(map);

        DrawNodeLinks();
    }

    public void DrawNodeLinks() {
        //Draw node-links
        for (int i = 0; i < networkNodes.Count - 1; i++) {
            for (int k = 0; k < networkNodes[i].Count; k++) {
                NetworkNode node = networkNodes[i][k];
                foreach(int exit in node.Node.ExitLinks) {
                    NetworkNode linkedNode = networkNodes[i + 1][exit];
                    node.DrawLineTo(linkedNode);
                }
            }
        }
    }
}
