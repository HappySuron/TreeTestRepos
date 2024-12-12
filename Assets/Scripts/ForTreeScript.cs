using System.Collections.Generic;

[System.Serializable]
public class Node
{
    public string nodeName;
    public List<Path> paths = new List<Path>();

    public Node(string name)
    {
        nodeName = name;
    }

    public void AddPath(Path path)
    {
        paths.Add(path);
    }
}

public class Path
{
    public Node targetNode;
    public string tokenType;
    public int tokensRequired;
    public string pathStatus;

    public Path(Node target, string token, int requiredTokens, string status)
    {
        targetNode = target;
        tokenType = token;
        tokensRequired = requiredTokens;
        pathStatus = status;
    }
}
