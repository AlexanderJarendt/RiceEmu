﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rice.Server.Structures
{
    public interface ISerializable
    {
        void Serialize(PacketWriter bw);
    }

    public class Vector4 : ISerializable
    {
        public float X, Y, Z, Rotation;

        public Vector4(float x, float y, float z, float rotation = 0)
        {
            X = x;
            Y = y;
            Z = z;
            Rotation = rotation;
        }

        public void Serialize(PacketWriter bw)
        {
            bw.Write(X);
            bw.Write(Y);
            bw.Write(Z);
            bw.Write(Rotation);
        }
    }
}
