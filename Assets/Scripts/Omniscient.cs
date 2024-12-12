using System.Collections.Generic;
using UnityEngine;

public class Omniscient : MonoBehaviour
{
    public Dictionary<string, int> tokens = new Dictionary<string, int>();
    public StateTree keyTree;
    public StateTree doorTree;

    void Start()
    {
        // Инициализируем жетоны
        tokens["key"] = 0;
        doorTree.MoveToNode("Дверь открыта", this);
        // Проверим взаимодействие
        //keyTree.MoveToNode("Ключ взят", this);
        keyTree.MoveToNode("Ключ тест", this);
        tokens["key"] = 1; // Дадим игроку ключ
        doorTree.MoveToNode("Дверь открыта", this);
    }

    // Проверка наличия токенов
    public bool HasTokens(string tokenType, int amount)
    {
        return tokens.ContainsKey(tokenType) && tokens[tokenType] >= amount;
    }

    //Использование токенов
    public void UseTokens(string tokenType, int amount)
    {
        if (HasTokens(tokenType, amount))
        {
            tokens[tokenType] -= amount;
            Debug.Log($"Использовано {amount} токенов {tokenType}. Осталось: {tokens[tokenType]}.");
        }
    }
}
