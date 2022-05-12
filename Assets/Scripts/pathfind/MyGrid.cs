using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGrid<T>
{
    private int width;
    private int height;
    private Vector3 originPosition;
    private T[,] gridArray;
    private float cellSize;

    public MyGrid(int width, int height, float cellSize, Vector3 originPosition)
	{
        this.width = width;
        this.height = height;
        this.originPosition = originPosition;
        this.cellSize = cellSize;
        gridArray = new T[width, height];
	}
}
