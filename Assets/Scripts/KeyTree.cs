using UnityEngine;

public class KeyTree : StateTree
{
    void Awake()
    {
        treeName = "KeyTree";

        // Создаем узлы
        Node keyAvailable = new Node("Ключ доступен");
        Node keyTaken = new Node("Ключ взят");
        Node keyTest = new Node("Ключ тест");

        // Добавляем пути
        keyAvailable.AddPath(new Path(keyTaken, "key", 0, "enabled"));

        keyTaken.AddPath(new Path(keyTest, "key", 0, "enabled"));

        // Заполняем список узлов
        nodes.Add(keyAvailable);
        nodes.Add(keyTaken);
        nodes.Add(keyTest);

        // Устанавливаем начальный узел
        currentNode = keyAvailable;
    }
}
