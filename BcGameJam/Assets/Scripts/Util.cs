using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    public enum Direction
    {
        Up,
        Right,
        Left,
        Down,
        Empty,
    }

    public static Vector2Int CalculateCoordinateFromDirection(Vector2Int coordinate, Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                return new Vector2Int(coordinate.x + 1, coordinate.y);
            case Direction.Right:
                return new Vector2Int(coordinate.x, coordinate.y + 1);
            case Direction.Left:
                return new Vector2Int(coordinate.x, coordinate.y - 1);
            case Direction.Down:
                return new Vector2Int(coordinate.x - 1, coordinate.y);
            case Direction.Empty:
                return coordinate;
        }
        return coordinate;
    }
    public static Direction GetOppositeDirection(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                return Direction.Down;
            case Direction.Right:
                return Direction.Left;
            case Direction.Left:
                return Direction.Right;
            case Direction.Down:
                return Direction.Up;
            case Direction.Empty:
                return Direction.Empty;
        }
        return Direction.Empty;
    }
    }
}