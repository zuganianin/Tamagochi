using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFind : MonoBehaviour
{
    private MyGrid<PathNode> grid;
    // Start is called before the first frame update
    public PathFind(int width, int height) {
        grid = new MyGrid<PathNode>(width, height, 10f, Vector3.zero);
    }

}
