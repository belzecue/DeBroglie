﻿namespace DeBroglie.Topo
{
    public enum DirectionsType
    {
        Unknown,
        Cartesian2d,
        Hexagonal2d,
        Cartesian3d,
    }

    public struct Directions
    {
        public int[] DX { get; private set; }
        public int[] DY { get; private set; }
        public int[] DZ { get; private set; }

        public int Count { get; private set; }

        public DirectionsType Type { get; private set; }

        public static readonly Directions Cartesian2d = new Directions
        {
            DX = new[] { 1, -1, 0, 0 },
            DY = new[] { 0, 0, 1, -1 },
            DZ = new[] { 0, 0, 0, 0 },
            Count = 4,
            Type = DirectionsType.Cartesian2d,
        };

        public static readonly Directions Hexagonal2d = new Directions
        {
            DX = new[] { 1, -1, 0, 0, 1, -1 },
            DY = new[] { 0, 0, 1, -1, 1, -1 },
            DZ = new[] { 0, 0, 0, 0, 0, 0 },
            Count = 6,
            Type = DirectionsType.Hexagonal2d,
        };


        public static readonly Directions Cartesian3d = new Directions
        {
            DX = new[] { 1, -1, 0, 0, 0, 0 },
            DY = new[] { 0, 0, 1, -1, 0, 0 },
            DZ = new[] { 0, 0, 0, 0, 1, -1 },
            Count = 6,
            Type = DirectionsType.Cartesian3d,
        };

        public int Inverse(int d)
        {
            return d ^ 1;
        }
    }
}