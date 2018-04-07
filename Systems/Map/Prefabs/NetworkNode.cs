using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Actualization of MapNode
public class NetworkNode : MonoBehaviour {
    [SerializeField] GameObject nodeLinePrefab;
    [SerializeField] Text coordinateLabel;

    private MapNode mapNode;

    public MapNode Node { get { return mapNode; } }

    public void Init(MapNode mapNode) {
        this.mapNode = mapNode;
        coordinateLabel.text = "(" + mapNode.NodeRow + "," + mapNode.NodePosition + ")";
	}

    public void DrawLineTo(NetworkNode destinationNode) {
        GameObject line = GameObject.Instantiate(nodeLinePrefab) as GameObject;
        line.transform.SetParent(transform, false);
        line.GetComponent<NodeLine>().DrawNewLineBetween(this.gameObject, destinationNode.gameObject);
    }
}
