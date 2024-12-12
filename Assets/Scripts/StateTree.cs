using System.Collections.Generic;
using UnityEngine;

public class StateTree : MonoBehaviour
{
    public string treeName;
    public Node currentNode;
    public List<Node> nodes = new List<Node>();

    // Метод для перехода в узел
    public void MoveToNode(string targetNodeName, Omniscient omniscient)
    {
        Node targetNode = nodes.Find(node => node.nodeName == targetNodeName);
        if (targetNode == null)
        {
            Debug.Log($"Узел {targetNodeName} не найден в дереве {treeName}.");
            return;
        }

        Path availablePath = currentNode.paths.Find(path => path.targetNode == targetNode);
        if (availablePath == null)
        {
            Debug.Log($"Нет доступного пути к узлу {targetNodeName}.");
            return;
        }

        if (omniscient.HasTokens(availablePath.tokenType, availablePath.tokensRequired))
        {
            omniscient.UseTokens(availablePath.tokenType, availablePath.tokensRequired);
            currentNode = targetNode;
            Debug.Log($"Перешли в узел: {currentNode.nodeName}");
        }
        else
        {
            Debug.Log($"Недостаточно токенов для перехода в узел: {targetNode.nodeName}.");
        }
    }
}
