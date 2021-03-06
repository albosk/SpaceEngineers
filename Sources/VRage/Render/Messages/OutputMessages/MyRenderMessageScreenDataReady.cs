﻿using VRageMath;

namespace VRageRender
{
    public class MyRenderMessageScreenDataReady : MyRenderMessageBase
    {
        public int Id;
        public byte[] ScreenData;
        public Vector2I Resolution;

        public override void Close()
        {
            Id = 0;
            ScreenData = null;
            Resolution = new Vector2I();

            base.Close();
        }

        public override MyRenderMessageType MessageClass { get { return MyRenderMessageType.StateChangeOnce; } }
        public override MyRenderMessageEnum MessageType { get { return MyRenderMessageEnum.ScreenDataReady; } }
    }
}